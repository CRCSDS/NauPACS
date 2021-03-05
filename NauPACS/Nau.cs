﻿using PACS_Dades;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Compression;

namespace NauPACS
{
    public partial class Nau : Form
    {

        //2 CLIENTS UNO PARA TEXTOS Y OTRO PARA ARCHIVOS

        TcpClient client = new TcpClient();
        Thread t1, t2;
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

        //IPAddress address = IPAddress.Parse("10.0.2.45");

        Int32 PlanetPortNumber;



        public Nau()
        {
            InitializeComponent();
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            t1 = new Thread(Connectar);
            t1.Start();
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
                            Control_operario.Text = "Se ha establecido la conexión a internet";
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

            //Conexion cliente //REVISARR

            ObtainPlanetNetwork();

            IPEndPoint endpoint = new IPEndPoint(PlanetIPAdress, PlanetPortNumber);

            try
            {
                client.Connect(endpoint);
                MessageBox.Show("Planeta encontrado! Listos para contactar");
                ConectplanetPanel.BackColor = Color.Green;

                //Byte[] dades = Encoding.ASCII.GetBytes("XML");
                //NetworkStream ns = client.GetStream();
                //ns.Write(dades, 0, dades.Length);

                //Control_operario.Text = "Se ha enviado un mensaje de texto";
            }
            catch
            {
                MessageBox.Show("ERROR: No se ha podido conectar al planeta. Vuelva a intentarlo o revise su conexión.");
                ConectplanetPanel.BackColor = Color.Red;
            }
        }

        private void btn_conectar_servidor_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            t2 = new Thread(Conectar_Servidor);
            t2.Start();
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
                        client = Listener.AcceptTcpClient();
                        ns = client.GetStream();
                        byte[] buffer = new byte[1024];
                        ns.Read(buffer, 0, buffer.Length);
                        data = Encoding.ASCII.GetString(buffer, 0, buffer.Length);
                        Msj_Recibido.Text = ("IP: " + ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString() + " ha enviat: " + data);
                    }
                }
            }

            catch (SocketException)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_desconectar_servidor_Click(object sender, EventArgs e)
        {
            t2.Abort();
            Listener.Stop();
        }

        private void btn_obtenir_codi_Click(object sender, EventArgs e)
        {

            txb_VCEncrypted.Clear();

            //Obtener idPlanet de la nave correspondiente al ComboBox:

            string query = "select idPlanet from DeliveryData where idSpaceShip = (select idSpaceShip from SpaceShips where CodeSpaceShip = (select CodeSpaceShipCategory from SpaceShipCategories where DescSpaceShipCategory = '" + cmb_Nau.Text + "'))";

            DataSet dts = bbdd.PortarPerConsulta(query);

            string planet_code = dts.Tables[0].Rows[0][0].ToString();


            //Obtener clave pública:

            query = "select XMLKey from PlanetKeys where idPlanet = '" + planet_code + "'";

            dts = bbdd.PortarPerConsulta(query);

            string PublicKey = dts.Tables[0].Rows[0][0].ToString();

            
            //Opción 2 - Guardar Clave a archivo XML:

            //dts.WriteXml("Customer.xml", XmlWriteMode.WriteSchema);


            //Obtener código de validación:

            query = "select ValidationCode from InnerEncryption where idPlanet = '" + planet_code + "'";

            dts = bbdd.PortarPerConsulta(query);

            string ValidationCode = dts.Tables[0].Rows[0][0].ToString();


            //Encriptar Código con Clave:

            rsaEnc.FromXmlString(PublicKey);

            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            byte[] dataToEncrypt = ByteConverter.GetBytes(ValidationCode);

            EncryptedData =
            RSAEncrypt(dataToEncrypt, rsaEnc.ExportParameters(false), false);

            txb_VCEncrypted.Text = Encoding.Default.GetString(EncryptedData);
        }

        private void Nau_Load(object sender, EventArgs e)
        {

            //string query = "select DescSpaceShipCategory from SpaceShipCategories";

            //inici = bbdd.PortarPerConsulta(query);


            //string dsadad = inici.Tables[0].Rows[0].ToString();
            //int Num_Tablas = inici.Tables.Count;

            //for (int i=0; i < inici.Tables.Count; i++)
            //{
            //    cmb_Nau.Items.Add(inici.Tables[i]);
            //}


            string query = "select * from SpaceShips SS, SpaceShipCategories SSC where SS.CodeSpaceShip = SSC.CodeSpaceShipCategory";

            inici = bbdd.PortarPerConsulta(query);

            cmb_Nau.DataSource = inici.Tables[0];
            cmb_Nau.ValueMember = "idSpaceShip";
            cmb_Nau.DisplayMember = "DescSpaceShipCategory";
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

     


        private void ObtainPlanetNetwork()
        {
            string query = "select idPlanet from DeliveryData where idSpaceShip = (select idSpaceShip from SpaceShips where CodeSpaceShip = (select CodeSpaceShipCategory from SpaceShipCategories where DescSpaceShipCategory = '" + cmb_Nau.Text + "'))";

            DataSet dts = bbdd.PortarPerConsulta(query);

            string IDPlanet = dts.Tables[0].Rows[0][0].ToString();

            query = "select IPPlanet from Planets where IDPlanet = '" + IDPlanet + "'";

            dts = bbdd.PortarPerConsulta(query);

            string IPPlanet = dts.Tables[0].Rows[0][0].ToString();



            query = "select PortPlanet from Planets where IDPlanet = '" + IDPlanet + "'";

            dts = bbdd.PortarPerConsulta(query);

            string PortPlanet = dts.Tables[0].Rows[0][0].ToString();


            PlanetIPAdress = IPAddress.Parse(IPPlanet);

            PlanetPortNumber = Int32.Parse(PortPlanet);

        }

        private void btn_enviarMensaje_Click(object sender, EventArgs e)
        {
            ns = client.GetStream();


            string query = "select idSpaceShip from SpaceShips where idSpaceShip = '" + cmb_Nau.SelectedItem + "'";

            DataSet dts = bbdd.PortarPerConsulta(query);

            string IdSpaceShip = dts.Tables[0].Rows[0][0].ToString();



            query = "select idDeliveryData from DeliveryData DD, SpaceShips SS,  where DD.idSpaceShip = SS.'" + cmb_Nau.SelectedItem + "'";
            dts = bbdd.PortarPerConsulta(query);

            string idDelivery = dts.Tables[0].Rows[0][0].ToString();


            Byte[] dades = Encoding.ASCII.GetBytes("ER"+IdSpaceShip+idDelivery);
            ns.Write(dades, 0, dades.Length);
            MessageBox.Show("Mensaje enviado con éxito.");
        }

        private void btn_enviarCV_Click(object sender, EventArgs e)
        {
            ns = client.GetStream();

            Byte[] dades = Encoding.ASCII.GetBytes("VK"+ txb_VCEncrypted.Text);
            ns.Write(dades, 0, dades.Length);
            MessageBox.Show("Codi de validació de la nau encriptat enviat!");
           
        }

        private void btn_tratarZip_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            t1.Abort();
            client.Close();
        }
    }
}

