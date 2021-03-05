using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PACS_Dades;

namespace PlanetaPACS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Dades bbdd = new Dades();
        string code;
        int port = 4500;
        char[] diccionari = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet dts = bbdd.PortarTaula("Planets");

            cmb_Planeta.DataSource = dts.Tables[0];
            cmb_Planeta.ValueMember = "idPlanet";
            cmb_Planeta.DisplayMember = "DescPlanet";

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_codi_Click(object sender, EventArgs e)
        {

            byte[] data = new byte[4 * diccionari.Length];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(diccionari.Length);
            for (int i = 0; i < 12; i++)
            {
                var random = BitConverter.ToUInt32(data, i * 4);
                var numero = random % diccionari.Length;

                result.Append(diccionari[numero]);
            }

            code = result.ToString();

            string idPlanet = Portar_idPlanet();

            DataSet dtsEncryption = bbdd.PortarTaula("InnerEncryption");
            string queryEncryption = "select * from InnerEncryption where idPlanet = '" + idPlanet + "'";

            DataSet dtsidEncryption = bbdd.PortarPerConsulta(queryEncryption);

            if (dtsidEncryption.Tables[0].Rows.Count > 0)
            {
                DataRow drEncryption = dtsidEncryption.Tables[0].Rows[0];
                drEncryption["ValidationCode"] = code;

                bbdd.Actualitzar(dtsidEncryption, queryEncryption);
            }
            else
            {
                DataRow drEncryption = dtsEncryption.Tables[0].NewRow();
                drEncryption["idPlanet"] = idPlanet;
                drEncryption["ValidationCode"] = code;

                dtsEncryption.Tables[0].Rows.Add(drEncryption);
                string query = "select * from InnerEncryption";
                bbdd.Actualitzar(dtsEncryption, query);
            }
        }

        private void btn_clau_Click(object sender, EventArgs e)
        {
            string planeta = cmb_Planeta.Text;
            string queryPlaneta = "select idPlanet from Planets where DescPlanet = '" + planeta + "'";
            DataSet dtsPlaneta = bbdd.PortarPerConsulta(queryPlaneta);
            string idPlanet = dtsPlaneta.Tables[0].Rows[0]["idPlanet"].ToString();

            string QueryValidation = "select ValidationCode from InnerEncryption where idPlanet = '" + idPlanet + "'";
            DataSet dtsValidation = bbdd.PortarPerConsulta(QueryValidation);
            string ValidationCode = dtsValidation.Tables[0].Rows[0]["ValidationCode"].ToString();

            CspParameters cspp = new CspParameters();
            string keyName = ValidationCode;
            cspp.KeyContainerName = keyName;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
            RSAParameters RSAKeyInfo = rsa.ExportParameters(false);

            string publicKey = rsa.ToXmlString(false);
            string privateKey = rsa.ToXmlString(true);
            rsa.PersistKeyInCsp = true;

            DataSet dtsPlanetKeys = bbdd.PortarTaula("PlanetKeys");
            string queryPlanetKeys = "select * from PlanetKeys where idPlanet = '" + idPlanet + "'";
            DataSet dtsidPlanetKeys = bbdd.PortarPerConsulta(queryPlanetKeys);

            if (dtsidPlanetKeys.Tables[0].Rows.Count > 0)
            {
                DataRow drPlanetKeys = dtsidPlanetKeys.Tables[0].Rows[0];
                drPlanetKeys["XMLKey"] = publicKey;

                bbdd.Actualitzar(dtsidPlanetKeys, queryPlanetKeys);
            }
            else
            {
                DataRow drPlanetKeys = dtsPlanetKeys.Tables[0].NewRow();
                drPlanetKeys["idPlanet"] = idPlanet;
                drPlanetKeys["XMLKey"] = publicKey;

                dtsPlanetKeys.Tables[0].Rows.Add(drPlanetKeys);
                string query = "select * from PlanetKeys";
                bbdd.Actualitzar(dtsPlanetKeys, query);
            }
        }

        Thread hilo;
        Boolean servidor = true;
        Boolean conectat = false;
        TcpListener Listener;
        TcpClient client;
        NetworkStream ns;

        private void btn_Servidor_Click(object sender, EventArgs e)
        {
            if (!conectat)
            {
                lb_Missatges.Items.Add("Servidor Conectat");
                conectat = true;
                servidor = true;
                hilo = new Thread(function);
                hilo.Start();
            }
        }
        private void function()
        {
            Listener = new TcpListener(IPAddress.Any, port);
            Listener.Start();

            while (servidor)
            {
                if (Listener.Pending())
                {
                    client = Listener.AcceptTcpClient();
                    ns = client.GetStream();
                    byte[] buffer = new byte[1024];
                    ns.Read(buffer, 0, buffer.Length);
                    lb_Missatges.Items.Add(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString() + " ha enviat: ");
                    lb_Missatges.Items.Add(Encoding.UTF8.GetString(buffer));
                }
            }
        }

        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            lb_Missatges.Items.Add("Servidor Desconectat");
            conectat = false;
            if (hilo != null)
            {
                servidor = false;
                hilo.Abort();
                Listener.Stop();
                if (ns != null)
                {
                    ns.Close();
                }
                if (client != null)
                {
                    client.Close();
                }
            }
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            lb_Missatges.Items.Add("Client Iniciat");
        }

        private void btn_DesconectarClient_Click(object sender, EventArgs e)
        {
            lb_Missatges.Items.Add("Client Desconectat");
        }

        private void btn_xifrat_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Xifrat = new Dictionary<string, string>();
            Random rnd = new Random();
            string num_rnd_string;
            Boolean a = true;
            string idPlanet = Portar_idPlanet();

            for (char l = 'A'; l < 'Z' + 1; l++)
            {
                int num_rnd = rnd.Next(999);

                while (Xifrat.ContainsValue(num_rnd.ToString()))
                {
                    num_rnd = rnd.Next(999);
                }

                num_rnd_string = num_rnd.ToString();

                if (num_rnd < 100 && num_rnd >= 0)
                {
                    num_rnd_string = num_rnd_string.PadLeft(3, '0');
                }

                Xifrat.Add(l.ToString(), num_rnd_string);

                DataSet dtsxifrat = bbdd.PortarTaula("InnerEncryptionData");
                DataRow drxifrat = dtsxifrat.Tables[0].NewRow();

                string queryid = "select * from InnerEncryption where idPlanet = '" + idPlanet + "'";
                DataSet dtsIdInnerEncryption = bbdd.PortarPerConsulta(queryid);
                string IdInnerEncryption = dtsIdInnerEncryption.Tables[0].Rows[0]["idInnerEncryption"].ToString();

                if (dtsIdInnerEncryption.Tables[0].Rows.Count > 0 && a)
                {
                    string queryDelete = "delete from InnerEncryptionData where IdInnerEncryption = '" + IdInnerEncryption + "'";
                    bbdd.Executa(queryDelete);
                    a = false;
                }

                drxifrat["IdInnerEncryption"] = IdInnerEncryption;
                drxifrat["Word"] = l.ToString();
                drxifrat["Numbers"] = num_rnd_string;
                dtsxifrat.Tables[0].Rows.Add(drxifrat);

                string query = "select * from InnerEncryptionData";
                bbdd.Actualitzar(dtsxifrat, query);

            }
            lb_Missatges.Items.Add("Diccionari generat correctament");
        }

        private string Portar_idPlanet()
        {
            string planeta = cmb_Planeta.Text;
            string queryPlaneta = "select idPlanet from Planets where DescPlanet = '" + planeta + "'";
            DataSet dtsPlaneta = bbdd.PortarPerConsulta(queryPlaneta);

            string idPlanet = dtsPlaneta.Tables[0].Rows[0]["idPlanet"].ToString();

            return idPlanet;
        }
    }
}
