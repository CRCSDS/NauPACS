using PACS_Dades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NauPACS
{
    public partial class Nau : Form
    {
        //Variables globales:

        private string Status = string.Empty;

        //Strings de mensaje:
        private string msj_ErrorConexion = "Sin conexión.";

        private string msj_ConexionEstablecida = "Conexión establecida con éxito.";

        //Clientes y Servidores:
        private TcpClient client = new TcpClient();

        private TcpClient server = new TcpClient();

        //Hilos:
        private Thread Files_Thread, ConnectServer_Thread;

        //Ping y acceso a internet:
        private Boolean xarxaDisponible;

        private Ping myPing = new Ping();
        private bool responPing = false;

        //Network Streams, conexiones TCP y IPs:
        private NetworkStream ns;

        private TcpListener Listener;
        private IPAddress PlanetIPAdress;
        private IPEndPoint endpoint;
        private String data = null;

        //BBDD:
        private Dades bbdd = new Dades();

        private DataSet inici;
        private Int32 PlanetPortNumber, PortPlanet1;
        private string idPlanet;
        private string idDelivery;

        //Encriptación por RSA:
        private byte[] EncryptedData;

        private byte[] elementencriptat;
        private RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();

        //Ficheros:
        private const int BufferSize = 1024;

        private string filepathZIP = Application.StartupPath + "\\PACS_Files\\PACS.zip";
        private string filepath = Application.StartupPath + "\\PACS_Files";

        // Arranque de fases del programa:
        private string tipo_mensaje, tipo_acceso;

        private int Estado = 0;
        private Boolean iss = false;

        public Nau()
        {
            InitializeComponent();
        }

        private void Connectar()
        {
            for (int i = 0; i < 11; i++)
            {
                try //Ping
                {
                    xarxaDisponible = NetworkInterface.GetIsNetworkAvailable();
                    PingReply reply = myPing.Send("8.8.8.8", 1000);

                    if (reply != null)
                    {
                        if (xarxaDisponible == true && reply.Status.ToString() == "Success")
                        {
                            responPing = reply.Status == IPStatus.Success;

                            ConnectedPB.ImageLocation = Application.StartupPath + "\\Assets\\SpaceShip_GreenButtonºrs.png";
                            ConnectedPB.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            ConnectedPB.ImageLocation = Application.StartupPath + "\\Assets\\SpaceShip_RedButtonºrs.png";
                            ConnectedPB.SizeMode = PictureBoxSizeMode.StretchImage;

                            Lb_Delegate("No se ha podido obtener respuesta por parte del domino o dirección IP.", ConsoleBox1);
                            Lb_Delegate(" ", ConsoleBox1);
                            //ConsoleBox1.Items.Add("No se ha podido obtener respuesta por parte del domino o dirección IP.");
                            //ConsoleBox1.Items.Add(" ");
                        }
                    }
                }
                catch (PingException pe)
                {
                    MessageBox.Show(pe.ToString());

                    Lb_Delegate(msj_ErrorConexion, ConsoleBox1);
                    Lb_Delegate(" ", ConsoleBox1);
                    //ConsoleBox1.Items.Add(msj_ErrorConexion);
                    //ConsoleBox1.Items.Add(" ");
                }
            }

            if (responPing) //Si por lo menos UNO de los pings responde:
            {
                Lb_Delegate("Acceso a internet aprobado.", ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add("Acceso a internet aprobado.");
                //ConsoleBox1.Items.Add(" ");
            }

            //Conexion cliente contra planeta:

            endpoint = ObtainPlanetNetwork();

            try
            {
                client.Connect(endpoint);

                Lb_Delegate("Planeta encontrado con éxtio, se ha establecido conexión con el servidor. Inicio de fase de comunicación.", ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add("Planeta encontrado con éxtio, se ha establecido conexión con el servidor. Inicio de fase de comunicación.");
                //ConsoleBox1.Items.Add(" ");

                ConnectToPlanetPB.ImageLocation = Application.StartupPath + "\\Assets\\SpaceShip_GreenButtonºrs.png";
                ConnectedPB.SizeMode = PictureBoxSizeMode.StretchImage;

                Lb_Delegate(msj_ConexionEstablecida, ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add(msj_ConexionEstablecida);
                //ConsoleBox1.Items.Add(" ");

                btn_conectar_servidor.Enabled = true;
                btn_conectar_servidor.ForeColor = System.Drawing.Color.Aqua;

                btn_desconectar_servidor.Enabled = true;
                btn_desconectar_servidor.ForeColor = System.Drawing.Color.Aqua;

                Lb_Delegate(" ", ConsoleBox2);
                Lb_Delegate("Planet Net Info:", ConsoleBox2);
                Lb_Delegate(" ", ConsoleBox2);
                Lb_Delegate("'" + endpoint.ToString() + "'", ConsoleBox2);
                //ConsoleBox1.Items.Add(" ");
                //ConsoleBox2.Items.Add("Planet Net Info:");
                //ConsoleBox1.Items.Add(" ");
                //ConsoleBox2.Items.Add("'" + endpoint.ToString() + "'");
            }
            catch
            {
                Lb_Delegate("No se ha podido conectar al planeta. Revise que el planeta destino coincida con su nave.", ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add("No se ha podido conectar al planeta. Revise que el planeta destino coincida con su nave.");
                //ConsoleBox1.Items.Add(" ");

                Lb_Delegate(msj_ErrorConexion, ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add(msj_ErrorConexion);
                //ConsoleBox1.Items.Add(" ");

                ConnectToPlanetPB.ImageLocation = Application.StartupPath + "\\Assets\\SpaceShip_RedButtonºrs.png";
                ConnectedPB.SizeMode = PictureBoxSizeMode.StretchImage;

                ConsoleBox2.Items.Clear();
            }
        }

        private void btn_conectar_servidor_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ConnectServer_Thread = new Thread(Conectar_Servidor);
            ConnectServer_Thread.Start();
        }

        public void RecibirArchivos()
        {
            bool ZipFileExists = false;

            string[] ExistingFiles;

            //Obtener Puerto del planeta correspondiente a la nave seleccionada:

            string query = "select P.PortPlanet1 from Planets P, DeliveryData D where D.idSpaceShip = (select idSpaceShip from SpaceShips where CodeSpaceShip = '" + cmb_Nau.Text + "') AND D.idPlanet = P.idPlanet;";

            DataSet dts = bbdd.PortarPerConsulta(query);

            PortPlanet1 = Int32.Parse(dts.Tables[0].Rows[0][0].ToString());

            TcpListener Listener = null;

            try
            {
                Listener = new TcpListener(IPAddress.Any, PortPlanet1);
                Listener.Start();
            }
            catch (Exception ex)
            {
                Lb_Delegate("ERROR: " + ex.Message, ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add("ERROR: " + ex.Message);
                Console.WriteLine(ex.Message);
            }

            byte[] RecData = new byte[BufferSize];
            int RecBytes;

            //Loop infinito (while)

            for (; ; )
            {
                TcpClient Archivos = null;
                NetworkStream netstream = null;
                Status = string.Empty;
                try
                {
                    string message = "Desea aceptar y recibir los archivos del planeta correspondiente?";
                    string caption = "Petición de inserción de archivos";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    if (Listener.Pending())
                    {
                        Archivos = Listener.AcceptTcpClient();
                        netstream = Archivos.GetStream();
                        Status = "Connected to a client\n";
                        result = MessageBox.Show(message, caption, buttons);

                        if (result == DialogResult.Yes)
                        {
                            Directory.CreateDirectory(filepath);

                            ZipFileExists = File.Exists(filepathZIP);

                            if (ZipFileExists) //Si el archivo comprimido existe, eliminalo junto a sus elementos extraidos en la carpeta seleccionada.
                            {
                                File.Delete(filepathZIP);

                                ExistingFiles = Directory.GetFiles(filepath, "PACS*.txt");

                                foreach (string file in ExistingFiles)
                                {
                                    File.Delete(file);
                                }
                            }

                            int totalrecbytes = 0;
                            FileStream Fs = new FileStream(filepathZIP, FileMode.OpenOrCreate, FileAccess.Write);

                            while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                            {
                                Fs.Write(RecData, 0, RecBytes);
                                totalrecbytes += RecBytes;
                            }
                            Fs.Close();

                            netstream.Close();
                            Archivos.Close();

                            Lb_Delegate("Alternando archivos, espere porfavor...", ConsoleBox1);
                            Lb_Delegate(" ", ConsoleBox1);
                            //ConsoleBox1.Items.Add("Alternando archivos, espere porfavor...");

                            //Descomprimir
                            ZipFile.ExtractToDirectory(filepathZIP, filepath);

                            //Tratar fichero:
                            tractar_fitxer();

                            Lb_Delegate("Archivos tratados correctamente. Presione 'Enviar Ficheros' para mandarlos hacia el planeta.", ConsoleBox1);
                            Lb_Delegate(" ", ConsoleBox1);
                            //ConsoleBox1.Items.Add("Archivos tratados correctamente. Presione 'Enviar Ficheros' para mandarlos hacia el planeta.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lb_Delegate("Error: " + ex.Message, ConsoleBox1);
                    Lb_Delegate(" ", ConsoleBox1);
                    //ConsoleBox1.Items.Add("Error: " + ex.Message);

                    //netstream.Close();
                }
            }
        }

        private void tractar_fitxer()
        {
            //Crear diccionario para referenciar con los numeros que devuelven los ficheros:

            string query = "select D.idPlanet from DeliveryData D, Planets P where D.idSpaceShip = (select idSpaceShip from SpaceShips where CodeSpaceShip = '" + cmb_Nau.Text + "') AND D.idPlanet = P.idPlanet;";
            DataSet dts = bbdd.PortarPerConsulta(query);
            idPlanet = dts.Tables[0].Rows[0][0].ToString();

            Dictionary<string, string> Diccionario = new Dictionary<string, string>();

            Diccionario = new Dictionary<string, string>();

            query = "SELECT * FROM innerEncryptionData ied, innerEncryption ie " +
                          "WHERE ied.idInnerEncryption = ie.idInnerEncryption AND idPlanet = '" + idPlanet + "'";

            dts = bbdd.PortarPerConsulta(query);

            for (int i = 0; i < 26; i++)
            {
                string Word = dts.Tables[0].Rows[i]["Word"].ToString();
                string Numbers = dts.Tables[0].Rows[i]["Numbers"].ToString();
                Diccionario.Add(Word, Numbers);
            }

            //Leer ficheros y guardar las "keys" equivalentes en un nuevo archivo:

            FileStream fs = File.Create(filepath + "\\PACCSOL.txt");

            StreamWriter writer = new StreamWriter(filepath + "\\PACSSOL.txt");

            for (int i = 1; i < 4; i++)
            {
                int x = 0;

                StreamReader File = new StreamReader(filepath + "\\PACS" + i + ".txt");

                string FileData = File.ReadToEnd();

                for (x = 0; x < FileData.Length; x = x + 3)
                {
                    string FileDigits = FileData.Substring(x, 3);

                    var myKey = Diccionario.FirstOrDefault(y => y.Value == FileDigits).Key;

                    writer.Write(myKey);
                }

                File.Close();
            }

            writer.Close();
        }

        private void Conectar_Servidor()
        {
            ConsoleBox1.Items.Clear();

            try
            {
                Listener = new TcpListener(IPAddress.Any, 4500);
                Listener.Start();
                iss = true;

                while (iss)
                {
                    //MENSAJES PARA EL OPERARIO

                    if (Listener.Pending())
                    {
                        server = Listener.AcceptTcpClient();
                        ns = server.GetStream();
                        byte[] buffer = new byte[1024];
                        ns.Read(buffer, 0, buffer.Length);
                        data = Encoding.ASCII.GetString(buffer, 0, buffer.Length);
                        tipo_mensaje = data.Substring(0, 2);
                        tipo_acceso = data.Substring(14, 2);

                        switch (tipo_mensaje)
                        {
                            case "VR":

                                //SIGUE EL PROGRAMA

                                if (tipo_acceso == "VP" && Estado == 0)
                                {
                                    try
                                    {
                                        Obtener_codi_validacio();
                                        Estado++;
                                    }
                                    catch
                                    {
                                        Lb_Delegate("ERROR: No se ha podido subministrar el codigo de validación.", ConsoleBox1);
                                        Lb_Delegate(" ", ConsoleBox1);
                                        //ConsoleBox1.Items.Add("ERROR: No se ha podido subministrar el codigo de validación.");
                                        Estado = 0;
                                    }
                                }
                                else if (tipo_acceso == "VP" && Estado == 1)
                                {
                                    Estado++;

                                    ThreadStart Ts = new ThreadStart(RecibirArchivos);
                                    Files_Thread = new Thread(Ts);
                                    Files_Thread.Start();
                                }
                                else if (tipo_acceso == "VP" && Estado == 2)
                                {
                                    AccessPB.ImageLocation = Application.StartupPath + "\\Assets\\SpaceShip_GreenButtonºrs.png";
                                    ConnectedPB.SizeMode = PictureBoxSizeMode.StretchImage;

                                    Lb_Delegate("Mensaje de Planeta: ACCESO PERMITIDO", ConsoleBox1);
                                    Lb_Delegate(" ", ConsoleBox1);
                                    //ConsoleBox1.Items.Add("Mensaje de Planeta: ACCESO PERMITIDO");
                                }
                                else
                                {
                                    Listener.Stop();
                                    ConnectServer_Thread.Abort();
                                    Estado = 0;
                                }

                                break;
                        }
                    }
                }
            }
            catch (SocketException se)
            {
                Lb_Delegate("ERROR: " + se.Message, ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add("ERROR: " + se.Message);
            }
        }

        //Threat Desconectar Server
        private void btn_desconectar_servidor_Click(object sender, EventArgs e)
        {
            Lb_Delegate("Apagando servidor, porfavor espere...", ConsoleBox1);
            Lb_Delegate(" ", ConsoleBox1);
            //ConsoleBox1.Items.Add("Apagando servidor, porfavor espere...");

            Files_Thread.Abort();
            ConnectServer_Thread.Abort();
            Listener.Stop();
            client.Close();
            client.Dispose();

            ConsoleBox1.Items.Clear();
            ConsoleBox2.Items.Clear();

            Lb_Delegate("El servidor se ha apagado correctamente.", ConsoleBox1);
            Lb_Delegate(" ", ConsoleBox1);
            //ConsoleBox1.Items.Add("El servidor se ha apagado correctamente.");
        }

        private void Obtener_codi_validacio()
        {
            //Obtener idPlanet de la nave correspondiente al ComboBox:

            string query = "select idPlanet from DeliveryData where idSpaceShip = (select idSpaceShip from SpaceShips where CodeSpaceShip = '" + cmb_Nau.Text + "')";

            DataSet dts = bbdd.PortarPerConsulta(query);

            string planet_code = dts.Tables[0].Rows[0][0].ToString();

            //Obtener clave pública y CV:

            query = "select * from PlanetKeys P, InnerEncryption IE where P.idPlanet = IE.idPlanet AND P.idPlanet = " + planet_code + "";

            dts = bbdd.PortarPerConsulta(query);

            string PublicKey = dts.Tables[0].Rows[0]["XMLKey"].ToString();

            string ValidationCode = dts.Tables[0].Rows[0]["ValidationCode"].ToString();

            //Encriptar Código con Clave:

            rsaEnc.FromXmlString(PublicKey);

            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            byte[] dataToEncrypt = ByteConverter.GetBytes(ValidationCode);
            elementencriptat = rsaEnc.Encrypt(dataToEncrypt, false);

            btn_enviarCV.Enabled = true;

            Lb_Delegate("CV: ", ConsoleBox2);
            Lb_Delegate(ByteConverter.GetString(elementencriptat), ConsoleBox2);
            Lb_Delegate(" ", ConsoleBox2);
            //ConsoleBox2.Items.Add("CV: ");
            //ConsoleBox2.Items.Add(ByteConverter.GetString(elementencriptat));
            //ConsoleBox2.Items.Add(" ");
        }

        private void Nau_Load(object sender, EventArgs e)
        {

            btn_ShutDown.BackgroundImageLayout = ImageLayout.Zoom;

            string query = "select * from SpaceShips";

            inici = bbdd.PortarPerConsulta(query);

            cmb_Nau.DataSource = inici.Tables[0];
            cmb_Nau.ValueMember = "idSpaceShip";
            cmb_Nau.DisplayMember = "CodeSpaceShip";
            cmb_Nau.SelectedIndex = 0;
        }

        public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            byte[] encryptedData;
            using (rsaEnc)
            {
                rsaEnc.ImportParameters(RSAKeyInfo);
                encryptedData = rsaEnc.Encrypt(DataToEncrypt, DoOAEPPadding);
            }
            return encryptedData;
        }

        private IPEndPoint ObtainPlanetNetwork()
        {
            string query = "select D.idPlanet,P.IPPlanet,P.PortPlanet from DeliveryData D, Planets P where D.idSpaceShip = (select idSpaceShip from SpaceShips where CodeSpaceShip = '" + cmb_Nau.Text + "') AND D.idPlanet = P.idPlanet;";

            DataSet dts = bbdd.PortarPerConsulta(query);

            PlanetIPAdress = IPAddress.Parse(dts.Tables[0].Rows[0][1].ToString());

            PlanetPortNumber = Int32.Parse(dts.Tables[0].Rows[0][2].ToString());

            IPEndPoint endpoint = new IPEndPoint(PlanetIPAdress, PlanetPortNumber);

            return endpoint;
        }

        private void btn_enviarFichero_Click(object sender, EventArgs e)
        {
            if (Estado >= 1)
            {
                //Enviar fichero tractado:

                string queryIP = "select IPPlanet, PortPlanet1 from Planets where idPlanet = 23";
                DataSet dtsConnectivitat = bbdd.PortarPerConsulta(queryIP);

                string Ip = dtsConnectivitat.Tables[0].Rows[0]["IPPlanet"].ToString();
                string Port = dtsConnectivitat.Tables[0].Rows[0]["PortPlanet1"].ToString();

                try
                {
                    TcpClient client = new TcpClient(Ip, int.Parse(Port));

                    NetworkStream ns = client.GetStream();
                    byte[] arxiu = File.ReadAllBytes(filepath + "\\PACSSOL.txt");
                    ns.Write(arxiu, 0, arxiu.Length);

                    client.Dispose();
                    client.Close();
                    ns.Close();
                    ns.Dispose();

                    Lb_Delegate("Archivos alternos enviados al planeta.", ConsoleBox1);
                    Lb_Delegate(" ", ConsoleBox1);
                    //ConsoleBox1.Items.Add("Archivos alternos enviados al planeta.");
                    //ConsoleBox1.Items.Add(" ");
                }
                catch (Exception ex)
                {
                    Lb_Delegate("ERROR: " + ex.ToString(), ConsoleBox1);
                    Lb_Delegate(" ", ConsoleBox1);
                    //ConsoleBox1.Items.Add("ERROR: " + ex.ToString());
                    //ConsoleBox1.Items.Add(" ");
                }
            }
        }

        private void ConsoleBox1_Click(object sender, EventArgs e)
        {
            if (ConsoleBox1.Height > 143 && ConsoleBox1.Width > 205)
            {
                ConsoleBox1.Dock = DockStyle.None;
                ConsoleBox1.Height = 108;
                ConsoleBox1.Width = 154;
                ConsoleBox1.Location = new Point(350, 633);
                ConsoleBox1.Font = new Font("Microsoft Sans Serif", 6);
            }
            else
            {
                ConsoleBox1.Dock = DockStyle.Fill;
                ConsoleBox1.BringToFront();
                ConsoleBox1.Font = new Font("Microsoft Sans Serif", 18);
            }
        }

        private void ConsoleBox2_Click(object sender, EventArgs e)
        {
            if (ConsoleBox2.Height > 143 && ConsoleBox2.Width > 205)
            {
                ConsoleBox2.Dock = DockStyle.None;
                ConsoleBox2.Height = 108;
                ConsoleBox2.Width = 161;
                ConsoleBox2.Location = new Point(1014, 630);
                ConsoleBox2.Font = new Font("Microsoft Sans Serif", 6);
            }
            else
            {
                ConsoleBox2.Dock = DockStyle.Fill;
                ConsoleBox2.BringToFront();
                ConsoleBox2.Font = new Font("Microsoft Sans Serif", 18);
            }
        }

        private void btn_PlanetConnect_Click(object sender, EventArgs e)
        {
            ConsoleBox1.Items.Clear();
            ConsoleBox2.Items.Clear();

            ConnectedPB.ImageLocation = Application.StartupPath + "\\Assets\\SpaceShip_DefaultButtonº.png";
            ConnectedPB.SizeMode = PictureBoxSizeMode.StretchImage;

            Lb_Delegate(" ", ConsoleBox1);
            Lb_Delegate("Iniciando conexión...", ConsoleBox1);
            Lb_Delegate(" ", ConsoleBox1);
            //ConsoleBox1.Items.Add(" ");
            //ConsoleBox1.Items.Add("Iniciando conexión...");
            //ConsoleBox1.Items.Add(" ");

            try
            {
                Connectar();
                ns = client.GetStream();

                string CodeSpaceShip = cmb_Nau.Text;
                idDelivery = dtg_Delivery.Rows[0].Cells["CodeDelivery"].Value.ToString();

                Byte[] dades = Encoding.ASCII.GetBytes("ER" + CodeSpaceShip + idDelivery);
                ns.Write(dades, 0, dades.Length);

                SkyBackGround.BackgroundImage = Properties.Resources.P1;
                SkyBackGround.BackgroundImageLayout = ImageLayout.Stretch;

                Lb_Delegate("Se ha enviado una petición de acceso al planeta.", ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add("Se ha enviado una petición de acceso al planeta.");
                //ConsoleBox1.Items.Add(" ");

                ns.Flush();
                ns.Dispose();
                ns.Close();
                client.Close();
                client.Dispose();
            }
            catch
            {
                SkyBackGround.BackgroundImage = Properties.Resources.SpaceBackGround;
                SkyBackGround.BackgroundImageLayout = ImageLayout.Stretch;

                Lb_Delegate("Su conexión con el planeta ha expirado.", ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                Lb_Delegate("----------------------------------------------", ConsoleBox1);
                //ConsoleBox1.Items.Add("Su conexión con el planeta ha expirado.");
                //ConsoleBox1.Items.Add(" ");
                //ConsoleBox1.Items.Add("----------------------------------------------");
            }
        }

        private void btn_ShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_enviarCV_Click(object sender, EventArgs e)
        {
            //Conectarse como cliente hacia el planeta:

            try
            {
                endpoint = ObtainPlanetNetwork();

                //Se declara un cliente para preguntar al planeta:

                TcpClient Nouclient = new TcpClient();
                Nouclient.Connect(endpoint);

                //Enviar CV a través del network stream:

                NetworkStream ns = Nouclient.GetStream();

                Byte[] dades = Encoding.ASCII.GetBytes("VK");

                ns.Write(dades, 0, dades.Length);

                Thread.Sleep(2000); //Parada del threat de 2s para esperar una respuesta del servidor antes de enviar el CV.

                dades = elementencriptat;

                ns.Write(dades, 0, dades.Length);

                btn_enviarFichero.Enabled = true;

                Lb_Delegate("Codigo de validación encriptado (CV) enviado.", ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add("Codigo de validación encriptado (CV) enviado.");

                Nouclient.Close();
            }
            catch
            {
                Lb_Delegate("ERROR: Problema al enviar código de validación al planeta.", ConsoleBox1);
                Lb_Delegate(" ", ConsoleBox1);
                //ConsoleBox1.Items.Add("ERROR: Problema al enviar código de validación al planeta.");
            }
        }

        private void cmb_Nau_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string query1 = "select * from DeliveryData where idSpaceShip = (select idSpaceShip from SpaceShips where CodeSpaceShip = '" + cmb_Nau.SelectedValue + "');";
                string query1 = "select * from DeliveryData where idSpaceShip = '" + cmb_Nau.SelectedValue + "';";
                DataSet dts_delivery = bbdd.PortarPerConsulta(query1);
                dtg_Delivery.DataSource = dts_delivery.Tables[0];
                dtg_Delivery.Columns["idDeliveryData"].Visible = false;
            }
            catch
            {
            }
        }

        //Delegate en la ListBox (ConsoleBox1 & 2)
        private void Lb_Delegate(string text, ListBox lb)
        {
            if (ConsoleBox1.InvokeRequired)
            {
                lb.Invoke((MethodInvoker)delegate
                {
                    lb.Items.Add(text);
                });
            }
            else
            {
                lb.Items.Add(text);
            }
        }


    }
}