using PACS_Dades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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

        //2 CLIENTS UNO PARA TEXTOS Y OTRO PARA ARCHIVOS
        private const int BufferSize = 1024;
        string Status = string.Empty;

        TcpClient client = new TcpClient();
        TcpClient server = new TcpClient();
        Thread T,t2;
        Boolean xarxaDisponible;
        Ping myPing = new Ping();
        bool responPing = false;

        NetworkStream ns;
        TcpListener Listener;
        Boolean iss = false;
        String data = null;

        Dades bbdd = new Dades();
        DataSet inici;


        byte[] EncryptedData;
        RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();


        IPAddress PlanetIPAdress;


        Int32 PlanetPortNumber,PortPlanet1;


        byte[] elementencriptat;

        IPEndPoint endpoint;

        string idDelivery;
        string tipo_mensaje, tipo_acceso;
        int Estado = 0;

        string filepathZIP = Application.StartupPath + "PACS.zip";
        string filepath = Application.StartupPath;


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
                //PING
                try
                {
                    xarxaDisponible = NetworkInterface.GetIsNetworkAvailable();
                    PingReply reply = myPing.Send("8.8.8.8", 1000);

                    if (reply != null)
                    {
                        if (xarxaDisponible == true && reply.Status.ToString() == "Success")
                        {
                            responPing = reply.Status == IPStatus.Success;
                            Control_operario.Text = "Establecida";
                            ConnectedPanel.BackColor = Color.Green;
                        }
                        else
                        {
                            Control_operario.Text = "No se ha podido establecer la conexión a internet. Verifique su conectividad con la red.";
                            ConnectedPanel.BackColor = Color.Red;
                        }
                    }
                }

                catch (PingException)
                {
                    Control_operario.Text = "No se ha podido obtener respuesta por parte del domino y/o dirección IP.";
                }
            }

            //Conexion cliente contra planeta

            endpoint = ObtainPlanetNetwork();

            try
            {
                client.Connect(endpoint);
                MessageBox.Show("Planeta encontrado! Listos para contactar.");
                ConectplanetPanel.BackColor = Color.Green;
                Control_operario_planeta.Text = "Establecida";
            }
            catch
            {
                Control_operario_planeta.Text = "No se ha podido conectar al planeta";
                ConectplanetPanel.BackColor = Color.Red;
            }
        }

        private void btn_conectar_servidor_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            t2 = new Thread(Conectar_Servidor);
            t2.Start();
        }


        public void RecivirArchivos()
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

                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            string SaveFileName = string.Empty;
                            SaveFileDialog DialogSave = new SaveFileDialog();
                            DialogSave.Filter = "All files (*.*)|*.*";
                            DialogSave.RestoreDirectory = true;
                            DialogSave.Title = "Where do you want to save the file?";
                            DialogSave.InitialDirectory = @"C:/";
                            if (DialogSave.ShowDialog() == DialogResult.OK)
                                SaveFileName = DialogSave.FileName;
                            if (SaveFileName != string.Empty)
                            {
                                int totalrecbytes = 0;
                                FileStream Fs = new FileStream(SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
                                while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                                {
                                    Fs.Write(RecData, 0, RecBytes);
                                    totalrecbytes += RecBytes;
                                }
                                Fs.Close();
                            }
                            netstream.Close();
                            Archivos.Close();

                            //Descomprimir
                            ZipFile.ExtractToDirectory(filepathZIP, filepath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //netstream.Close();
                }
            }
        }



        private void tractar_fitxer()
        {
            string query = "select * from InnerEncryptionData IED, InnerEncryption IE where "; //Query a InnerEncryptionData para obtener la ID y los valores

            Dictionary<string, string> Diccionario;







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

                                if (tipo_acceso == "VP")
                                {
                                    try
                                    {
                                        Obtener_codi_validacio();
                                        Estado++;

                                    }
                                    catch
                                    {
                                        MessageBox.Show("No se ha subministrado el codigo de validación");
                                        Estado = 0;
                                    }
                                }
                                else if (tipo_acceso == "VP" && Estado == 1)
                                {
                                    Estado++;

                                    ThreadStart Ts = new ThreadStart(RecivirArchivos);
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

            query = "Select P.XMLKey, IE.ValidationCode from PlanetKeys P, InnerEncryption IE where P.idPlanet = " + planet_code + "";

            dts = bbdd.PortarPerConsulta(query);

            string PublicKey = dts.Tables[0].Rows[0][0].ToString();

            string ValidationCode = dts.Tables[0].Rows[0][1].ToString();


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
            if(Estado >= 1)
            {
                //Tratar fichero y enviarlo a planeta
            }
        }

        private void btn_enviarMensaje_Click(object sender, EventArgs e)
        {
            try
            {
                Connectar();
                ns = client.GetStream();

                string IdSpaceShip = cmb_Nau.Text;
                idDelivery = dtg_Delivery.Rows[0].Cells["CodeDelivery"].Value.ToString();

                Byte[] dades = Encoding.ASCII.GetBytes("ER" + IdSpaceShip + idDelivery);
                ns.Write(dades, 0, dades.Length);
                MessageBox.Show("Mensaje enviado con éxito.");

                ns.Flush();
                ns.Dispose();
                ns.Close();
                client.Close();
                client.Dispose();
            }
            catch
            {
                MessageBox.Show("Error de conexión, vuelva a intentarlo");
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
            catch
            {

            }

        }
    }
}

