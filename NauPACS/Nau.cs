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


        string Status = string.Empty;


        //Strings de mensaje:
        string msj_ErrorConexion = "Sin conexión.";
        string msj_ConexionEstablecida = "Establecida.";

        //Clientes y Servidores:
        TcpClient client = new TcpClient();
        TcpClient server = new TcpClient();

        //Hilos:
        Thread T, t2;

        //Ping y acceso a internet:
        Boolean xarxaDisponible;
        Ping myPing = new Ping();
        bool responPing = false;

        //Network Streams, conexiones TCP y IPs:
        NetworkStream ns;
        TcpListener Listener;
        IPAddress PlanetIPAdress;
        IPEndPoint endpoint;
        String data = null;

        //BBDD:
        Dades bbdd = new Dades();
        DataSet inici;
        Int32 PlanetPortNumber, PortPlanet1;
        string idPlanet;
        string idDelivery;

        //Encriptación por RSA:
        byte[] EncryptedData;
        byte[] elementencriptat;
        RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();

        //Ficheros:
        private const int BufferSize = 1024;
        string filepathZIP = Application.StartupPath + "\\PACS.zip";
        string filepath = Application.StartupPath;

        // Arranque de fases del programa:
        string tipo_mensaje, tipo_acceso;
        int Estado = 0;
        Boolean iss = false;


        public Nau()
        {
            InitializeComponent();
        }

        private void Connectar()
        {
            ConnectedPanel.BackColor = Color.Gray;
            ConectplanetPanel.BackColor = Color.Gray;

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
                            Control_operario.Text = msj_ConexionEstablecida;
                            ConnectedPanel.BackColor = Color.Green;
                        }
                        else
                        {
                            Control_operario.Text = "No se ha podido obtener respuesta por parte del domino o dirección IP.";
                            ConnectedPanel.BackColor = Color.Red;
                        }
                    }
                }

                catch (PingException pe)
                {
                    MessageBox.Show(pe.ToString());
                    Control_operario.Text = msj_ErrorConexion;
                }
            }


            //Conexion cliente contra planeta:

            endpoint = ObtainPlanetNetwork();

            try
            {
                client.Connect(endpoint);
                MessageBox.Show("Planeta encontrado. Listos para contactar.");
                ConectplanetPanel.BackColor = Color.Green;
                Control_operario_planeta.Text = msj_ConexionEstablecida;

                btn_conectar_servidor.Enabled = true;
                btn_conectar_servidor.ForeColor = System.Drawing.Color.Black;

                btn_desconectar_servidor.Enabled = true;
                btn_desconectar_servidor.ForeColor = System.Drawing.Color.Black;

            }
            catch
            {
                MessageBox.Show("No se ha podido conectar al planeta. Revise que el planeta destino coincida con su nave.");
                Control_operario_planeta.Text = msj_ErrorConexion;
                ConectplanetPanel.BackColor = Color.Red;
            }
        }



        private void btn_conectar_servidor_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            t2 = new Thread(Conectar_Servidor);
            t2.Start();
        }


        public void RecibirArchivos()
        {
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
                    string message = "Accept the Incoming File ";
                    string caption = "Incoming Connection";
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

                            //Descomprimir
                            ZipFile.ExtractToDirectory(filepathZIP, filepath);

                            //Tratar fichero:
                            tractar_fitxer();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    //netstream.Close();
                }
            }
        }



        private void tractar_fitxer()
        {
            /* string query = "select * from InnerEncryptionData IED, InnerEncryption IE where "; *///Query a InnerEncryptionData para obtener la ID y los valores

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

            string line;

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
                        Msj_Recibido.Text = data;
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
                                        MessageBox.Show("No se ha subministrado el codigo de validación.");
                                        Estado = 0;
                                    }
                                }
                                else if (tipo_acceso == "VP" && Estado == 1)
                                {
                                    Estado++;

                                    ThreadStart Ts = new ThreadStart(RecibirArchivos);
                                    T = new Thread(Ts);
                                    T.Start();
                                }
                                else if (tipo_acceso == "VP" && Estado == 2)
                                {
                                    MessageBox.Show("ACCÉS PERMÉS");
                                }
                                else
                                {
                                    Listener.Stop();
                                    t2.Abort();
                                    Estado = 0;
                                }

                                break;

                        }
                    }
                }
            }
            catch (SocketException)
            {
                MessageBox.Show("ERROR");
            }
        }


        //Threat Desconectar Server
        private void btn_desconectar_servidor_Click(object sender, EventArgs e)
        {
            t2.Abort();
            Listener.Stop();
            client.Close();
            client.Dispose();
            T.Abort();
        }


        private void Obtener_codi_validacio()
        {
            txb_VCEncrypted.Clear();

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
            txb_VCEncrypted.Text = ByteConverter.GetString(elementencriptat);
        }


        private void Nau_Load(object sender, EventArgs e)
        {
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
                //Enviar fichero tractado

                string queryIP = "select IPPlanet, PortPlanet1 from Planets where idPlanet = 23";
                DataSet dtsConnectivitat = bbdd.PortarPerConsulta(queryIP);

                string Ip = dtsConnectivitat.Tables[0].Rows[0]["IPPlanet"].ToString();
                string Port = dtsConnectivitat.Tables[0].Rows[0]["PortPlanet1"].ToString();

                try
                {
                    TcpClient client = new TcpClient(Ip, int.Parse(Port));

                    NetworkStream ns = client.GetStream();
                    byte[] arxiu = File.ReadAllBytes(Application.StartupPath + "\\PACSSOL.txt");
                    ns.Write(arxiu, 0, arxiu.Length);

                    client.Dispose();
                    client.Close();
                    ns.Close();
                    ns.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }


        private void btn_PlanetConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Connectar();
                ns = client.GetStream();

                string CodeSpaceShip = cmb_Nau.Text;
                idDelivery = dtg_Delivery.Rows[0].Cells["CodeDelivery"].Value.ToString();

                Byte[] dades = Encoding.ASCII.GetBytes("ER" + CodeSpaceShip + idDelivery);
                ns.Write(dades, 0, dades.Length);
                MessageBox.Show("Su mensaje se ha enviado con éxito.");

                ns.Flush();
                ns.Dispose();
                ns.Close();
                client.Close();
                client.Dispose();
            }
            catch
            {
                MessageBox.Show("Su conexión con el planeta ha expirado.");
            }
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

                dades = elementencriptat;

                ns.Write(dades, 0, dades.Length);

                MessageBox.Show("Codi de validació de la nau encriptat enviat!");

                Nouclient.Close();
            }
            catch
            {
                MessageBox.Show("Error a l´enviar el CV");
            }
        }

        private void cmb_Nau_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query1 = "select * from DeliveryData where idSpaceShip = '" + cmb_Nau.SelectedValue + "'";
                DataSet dts_delivery = bbdd.PortarPerConsulta(query1);
                dtg_Delivery.DataSource = dts_delivery.Tables[0];
                dtg_Delivery.Columns["idDeliveryData"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

