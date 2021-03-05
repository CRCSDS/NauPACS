using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PACS_Dades;

namespace NauPACS
{
    public partial class Nau : Form
    {
        //2 CLIENTS UNO PARA TEXTOS Y OTRO PARA ARCHIVOS
        TcpClient client;
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

            private void Connectar() {

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
                            Control_operario.Text = "Ping Correcto, tienes conexión";
                        }
                        else
                        {
                            MessageBox.Show("Ping no contesta o Planeta no disponible");
                        }
                    }
                }

                catch (PingException)
                {
                    MessageBox.Show("Ping no contesta o Xarxa no disponible");
                }
            }
            //Conexion cliente
            try
                {
                    client = new TcpClient("10.0.2.36", 4500);
                    Byte[] dades = Encoding.ASCII.GetBytes("XML");
                    NetworkStream ns = client.GetStream();
                    ns.Write(dades, 0, dades.Length);

                    Control_operario.Text = "Se ha enviado un mensaje de texto";
                }
                catch
                {
                    MessageBox.Show("Planeta Desconectat");
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
                        data = System.Text.Encoding.ASCII.GetString(buffer, 0, buffer.Length);
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

            //String NomTaula = "Orders";
            //String CampTaula = "idOrder";


            //DataTable infotaula = dts.Tables[0];

            //string query = "select idPlanet from DeliveryData where idSpaceShip = (select idSpaceShip from SpaceShips where idSpaceShip = '" + dts.Tables[0] + "';";

 
            string query = "select idPlanet from DeliveryData where idSpaceShip = (select idSpaceShip from SpaceShips where CodeSpaceShip = (select CodeSpaceShipCategory from SpaceShipCategories where DescSpaceShipCategory = '" + cmb_Nau.SelectedItem + "'))";

            DataSet dts = bbdd.PortarPerConsulta(query);



        }

        private void Nau_Load(object sender, EventArgs e)
        {
            
            string query = "select * from SpaceShips SS, SpaceShipCategories SSC where SS.CodeSpaceShip = SSC.CodeSpaceShipCategory";

            inici = bbdd.PortarPerConsulta(query);

            cmb_Nau.DataSource = inici.Tables[0];
            cmb_Nau.ValueMember = "idSpaceShip";
            cmb_Nau.DisplayMember = "DescSpaceShipCategory";
        }


        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            t1.Abort();
            client.Close();
        }
    }
}

