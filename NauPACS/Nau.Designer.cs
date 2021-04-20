
namespace NauPACS
{
    partial class Nau
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pacsDataSet = new NauPACS.pacsDataSet();
            this.pacsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SkyBackGround = new System.Windows.Forms.Panel();
            this.SpaceShipBackGround = new System.Windows.Forms.Panel();
            this.panel_MBtnTexture = new System.Windows.Forms.Panel();
            this.btn_ShutDown = new System.Windows.Forms.Button();
            this.panel_SDBtnTexture = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.Pl_PlanetHolograma = new System.Windows.Forms.PictureBox();
            this.AccessPB = new System.Windows.Forms.PictureBox();
            this.ConnectToPlanetPB = new System.Windows.Forms.PictureBox();
            this.ConnectedPB = new System.Windows.Forms.PictureBox();
            this.ConsoleBox2 = new System.Windows.Forms.ListBox();
            this.cmb_Nau = new System.Windows.Forms.ComboBox();
            this.dtg_Delivery = new System.Windows.Forms.DataGridView();
            this.ConsoleBox1 = new System.Windows.Forms.ListBox();
            this.btn_PlanetConnect = new System.Windows.Forms.Button();
            this.btn_enviarCV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_desconectar_servidor = new System.Windows.Forms.Button();
            this.btn_conectar_servidor = new System.Windows.Forms.Button();
            this.btn_enviarFichero = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSetBindingSource)).BeginInit();
            this.SkyBackGround.SuspendLayout();
            this.SpaceShipBackGround.SuspendLayout();
            this.panel_MBtnTexture.SuspendLayout();
            this.panel_SDBtnTexture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pl_PlanetHolograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectToPlanetPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Delivery)).BeginInit();
            this.SuspendLayout();
            // 
            // pacsDataSet
            // 
            this.pacsDataSet.DataSetName = "pacsDataSet";
            this.pacsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacsDataSetBindingSource
            // 
            this.pacsDataSetBindingSource.DataSource = this.pacsDataSet;
            this.pacsDataSetBindingSource.Position = 0;
            // 
            // SkyBackGround
            // 
            this.SkyBackGround.BackgroundImage = global::NauPACS.Properties.Resources.SpaceBackGround;
            this.SkyBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SkyBackGround.Controls.Add(this.SpaceShipBackGround);
            this.SkyBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkyBackGround.Location = new System.Drawing.Point(0, 0);
            this.SkyBackGround.Name = "SkyBackGround";
            this.SkyBackGround.Size = new System.Drawing.Size(1920, 1055);
            this.SkyBackGround.TabIndex = 25;
            // 
            // SpaceShipBackGround
            // 
            this.SpaceShipBackGround.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShipBackGround.BackgroundImage = global::NauPACS.Properties.Resources.spaceship_hud_rs2;
            this.SpaceShipBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpaceShipBackGround.Controls.Add(this.panel_MBtnTexture);
            this.SpaceShipBackGround.Controls.Add(this.panel_SDBtnTexture);
            this.SpaceShipBackGround.Controls.Add(this.Pl_PlanetHolograma);
            this.SpaceShipBackGround.Controls.Add(this.AccessPB);
            this.SpaceShipBackGround.Controls.Add(this.ConnectToPlanetPB);
            this.SpaceShipBackGround.Controls.Add(this.ConnectedPB);
            this.SpaceShipBackGround.Controls.Add(this.ConsoleBox2);
            this.SpaceShipBackGround.Controls.Add(this.cmb_Nau);
            this.SpaceShipBackGround.Controls.Add(this.dtg_Delivery);
            this.SpaceShipBackGround.Controls.Add(this.ConsoleBox1);
            this.SpaceShipBackGround.Controls.Add(this.btn_PlanetConnect);
            this.SpaceShipBackGround.Controls.Add(this.btn_enviarCV);
            this.SpaceShipBackGround.Controls.Add(this.label5);
            this.SpaceShipBackGround.Controls.Add(this.btn_desconectar_servidor);
            this.SpaceShipBackGround.Controls.Add(this.btn_conectar_servidor);
            this.SpaceShipBackGround.Controls.Add(this.btn_enviarFichero);
            this.SpaceShipBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpaceShipBackGround.Location = new System.Drawing.Point(0, 0);
            this.SpaceShipBackGround.Name = "SpaceShipBackGround";
            this.SpaceShipBackGround.Size = new System.Drawing.Size(1920, 1055);
            this.SpaceShipBackGround.TabIndex = 25;
            // 
            // panel_MBtnTexture
            // 
            this.panel_MBtnTexture.BackgroundImage = global::NauPACS.Properties.Resources.SpaceShip_ButtonTextureº;
            this.panel_MBtnTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_MBtnTexture.Controls.Add(this.btn_ShutDown);
            this.panel_MBtnTexture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_MBtnTexture.Location = new System.Drawing.Point(1856, 3);
            this.panel_MBtnTexture.Name = "panel_MBtnTexture";
            this.panel_MBtnTexture.Size = new System.Drawing.Size(64, 54);
            this.panel_MBtnTexture.TabIndex = 36;
            // 
            // btn_ShutDown
            // 
            this.btn_ShutDown.BackColor = System.Drawing.Color.Transparent;
            this.btn_ShutDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShutDown.FlatAppearance.BorderSize = 0;
            this.btn_ShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShutDown.ForeColor = System.Drawing.Color.Red;
            this.btn_ShutDown.Location = new System.Drawing.Point(3, 3);
            this.btn_ShutDown.Name = "btn_ShutDown";
            this.btn_ShutDown.Size = new System.Drawing.Size(58, 48);
            this.btn_ShutDown.TabIndex = 33;
            this.btn_ShutDown.Text = "X";
            this.btn_ShutDown.UseVisualStyleBackColor = false;
            this.btn_ShutDown.Click += new System.EventHandler(this.btn_ShutDown_Click);
            // 
            // panel_SDBtnTexture
            // 
            this.panel_SDBtnTexture.BackgroundImage = global::NauPACS.Properties.Resources.SpaceShip_ButtonTextureº;
            this.panel_SDBtnTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_SDBtnTexture.Controls.Add(this.btn_Minimize);
            this.panel_SDBtnTexture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_SDBtnTexture.Location = new System.Drawing.Point(1786, 3);
            this.panel_SDBtnTexture.Name = "panel_SDBtnTexture";
            this.panel_SDBtnTexture.Size = new System.Drawing.Size(64, 54);
            this.panel_SDBtnTexture.TabIndex = 35;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.Red;
            this.btn_Minimize.Location = new System.Drawing.Point(3, -3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(61, 54);
            this.btn_Minimize.TabIndex = 34;
            this.btn_Minimize.Text = "-";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // Pl_PlanetHolograma
            // 
            this.Pl_PlanetHolograma.Image = global::NauPACS.Properties.Resources.Planet_Holograma;
            this.Pl_PlanetHolograma.Location = new System.Drawing.Point(977, 708);
            this.Pl_PlanetHolograma.Name = "Pl_PlanetHolograma";
            this.Pl_PlanetHolograma.Size = new System.Drawing.Size(60, 39);
            this.Pl_PlanetHolograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pl_PlanetHolograma.TabIndex = 32;
            this.Pl_PlanetHolograma.TabStop = false;
            // 
            // AccessPB
            // 
            this.AccessPB.Image = global::NauPACS.Properties.Resources.SpaceShip_DefaultButtonº;
            this.AccessPB.Location = new System.Drawing.Point(1241, 759);
            this.AccessPB.Name = "AccessPB";
            this.AccessPB.Size = new System.Drawing.Size(53, 28);
            this.AccessPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccessPB.TabIndex = 30;
            this.AccessPB.TabStop = false;
            // 
            // ConnectToPlanetPB
            // 
            this.ConnectToPlanetPB.Image = global::NauPACS.Properties.Resources.SpaceShip_DefaultButtonº;
            this.ConnectToPlanetPB.Location = new System.Drawing.Point(746, 809);
            this.ConnectToPlanetPB.Name = "ConnectToPlanetPB";
            this.ConnectToPlanetPB.Size = new System.Drawing.Size(53, 28);
            this.ConnectToPlanetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConnectToPlanetPB.TabIndex = 29;
            this.ConnectToPlanetPB.TabStop = false;
            // 
            // ConnectedPB
            // 
            this.ConnectedPB.Image = global::NauPACS.Properties.Resources.SpaceShip_DefaultButtonº;
            this.ConnectedPB.Location = new System.Drawing.Point(746, 759);
            this.ConnectedPB.Name = "ConnectedPB";
            this.ConnectedPB.Size = new System.Drawing.Size(53, 28);
            this.ConnectedPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConnectedPB.TabIndex = 28;
            this.ConnectedPB.TabStop = false;
            // 
            // ConsoleBox2
            // 
            this.ConsoleBox2.BackColor = System.Drawing.Color.Black;
            this.ConsoleBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsoleBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleBox2.ForeColor = System.Drawing.Color.Lime;
            this.ConsoleBox2.FormattingEnabled = true;
            this.ConsoleBox2.Location = new System.Drawing.Point(1352, 775);
            this.ConsoleBox2.Name = "ConsoleBox2";
            this.ConsoleBox2.Size = new System.Drawing.Size(215, 143);
            this.ConsoleBox2.TabIndex = 26;
            this.ConsoleBox2.Click += new System.EventHandler(this.ConsoleBox2_Click);
            // 
            // cmb_Nau
            // 
            this.cmb_Nau.BackColor = System.Drawing.Color.Black;
            this.cmb_Nau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Nau.ForeColor = System.Drawing.Color.Aqua;
            this.cmb_Nau.FormattingEnabled = true;
            this.cmb_Nau.Location = new System.Drawing.Point(918, 572);
            this.cmb_Nau.Name = "cmb_Nau";
            this.cmb_Nau.Size = new System.Drawing.Size(170, 24);
            this.cmb_Nau.TabIndex = 8;
            this.cmb_Nau.SelectedIndexChanged += new System.EventHandler(this.cmb_Nau_SelectedIndexChanged);
            // 
            // dtg_Delivery
            // 
            this.dtg_Delivery.AllowUserToAddRows = false;
            this.dtg_Delivery.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dtg_Delivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Delivery.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_Delivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Delivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Delivery.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Delivery.EnableHeadersVisualStyles = false;
            this.dtg_Delivery.GridColor = System.Drawing.Color.Cyan;
            this.dtg_Delivery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtg_Delivery.Location = new System.Drawing.Point(746, 601);
            this.dtg_Delivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_Delivery.Name = "dtg_Delivery";
            this.dtg_Delivery.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Delivery.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Delivery.RowHeadersVisible = false;
            this.dtg_Delivery.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dtg_Delivery.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Delivery.RowTemplate.Height = 28;
            this.dtg_Delivery.Size = new System.Drawing.Size(548, 85);
            this.dtg_Delivery.TabIndex = 21;
            // 
            // ConsoleBox1
            // 
            this.ConsoleBox1.BackColor = System.Drawing.Color.Black;
            this.ConsoleBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsoleBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleBox1.ForeColor = System.Drawing.Color.Lime;
            this.ConsoleBox1.FormattingEnabled = true;
            this.ConsoleBox1.Location = new System.Drawing.Point(466, 779);
            this.ConsoleBox1.Name = "ConsoleBox1";
            this.ConsoleBox1.Size = new System.Drawing.Size(205, 143);
            this.ConsoleBox1.TabIndex = 25;
            this.ConsoleBox1.Click += new System.EventHandler(this.ConsoleBox1_Click);
            // 
            // btn_PlanetConnect
            // 
            this.btn_PlanetConnect.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlanetConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_PlanetConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlanetConnect.FlatAppearance.BorderSize = 0;
            this.btn_PlanetConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlanetConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlanetConnect.ForeColor = System.Drawing.Color.Aqua;
            this.btn_PlanetConnect.Image = global::NauPACS.Properties.Resources.SpaceShip_ButtonTextureº;
            this.btn_PlanetConnect.Location = new System.Drawing.Point(499, 657);
            this.btn_PlanetConnect.Name = "btn_PlanetConnect";
            this.btn_PlanetConnect.Size = new System.Drawing.Size(188, 90);
            this.btn_PlanetConnect.TabIndex = 16;
            this.btn_PlanetConnect.Text = "Conectar a planeta";
            this.btn_PlanetConnect.UseVisualStyleBackColor = false;
            this.btn_PlanetConnect.Click += new System.EventHandler(this.btn_PlanetConnect_Click);
            // 
            // btn_enviarCV
            // 
            this.btn_enviarCV.BackColor = System.Drawing.Color.Transparent;
            this.btn_enviarCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviarCV.Enabled = false;
            this.btn_enviarCV.FlatAppearance.BorderSize = 0;
            this.btn_enviarCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviarCV.ForeColor = System.Drawing.Color.Aqua;
            this.btn_enviarCV.Image = global::NauPACS.Properties.Resources.SpaceShip_ButtonTextureº;
            this.btn_enviarCV.Location = new System.Drawing.Point(1292, 963);
            this.btn_enviarCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviarCV.Name = "btn_enviarCV";
            this.btn_enviarCV.Size = new System.Drawing.Size(213, 85);
            this.btn_enviarCV.TabIndex = 2;
            this.btn_enviarCV.Text = "Enviar CV";
            this.btn_enviarCV.UseVisualStyleBackColor = false;
            this.btn_enviarCV.Click += new System.EventHandler(this.btn_enviarCV_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 905);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fichero a enviar:";
            // 
            // btn_desconectar_servidor
            // 
            this.btn_desconectar_servidor.BackColor = System.Drawing.Color.Transparent;
            this.btn_desconectar_servidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desconectar_servidor.Enabled = false;
            this.btn_desconectar_servidor.FlatAppearance.BorderSize = 0;
            this.btn_desconectar_servidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desconectar_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desconectar_servidor.ForeColor = System.Drawing.Color.Aqua;
            this.btn_desconectar_servidor.Image = global::NauPACS.Properties.Resources.SpaceShip_ButtonTextureº;
            this.btn_desconectar_servidor.Location = new System.Drawing.Point(546, 949);
            this.btn_desconectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconectar_servidor.Name = "btn_desconectar_servidor";
            this.btn_desconectar_servidor.Size = new System.Drawing.Size(215, 100);
            this.btn_desconectar_servidor.TabIndex = 5;
            this.btn_desconectar_servidor.Text = "Desconectar servidor";
            this.btn_desconectar_servidor.UseVisualStyleBackColor = false;
            this.btn_desconectar_servidor.Click += new System.EventHandler(this.btn_desconectar_servidor_Click);
            // 
            // btn_conectar_servidor
            // 
            this.btn_conectar_servidor.BackColor = System.Drawing.Color.Transparent;
            this.btn_conectar_servidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_conectar_servidor.Enabled = false;
            this.btn_conectar_servidor.FlatAppearance.BorderSize = 0;
            this.btn_conectar_servidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar_servidor.ForeColor = System.Drawing.Color.Aqua;
            this.btn_conectar_servidor.Image = global::NauPACS.Properties.Resources.SpaceShip_ButtonTextureº;
            this.btn_conectar_servidor.Location = new System.Drawing.Point(333, 949);
            this.btn_conectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_conectar_servidor.Name = "btn_conectar_servidor";
            this.btn_conectar_servidor.Size = new System.Drawing.Size(207, 100);
            this.btn_conectar_servidor.TabIndex = 4;
            this.btn_conectar_servidor.Text = "Conectar servidor";
            this.btn_conectar_servidor.UseVisualStyleBackColor = false;
            this.btn_conectar_servidor.Click += new System.EventHandler(this.btn_conectar_servidor_Click);
            // 
            // btn_enviarFichero
            // 
            this.btn_enviarFichero.BackColor = System.Drawing.Color.Transparent;
            this.btn_enviarFichero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviarFichero.Enabled = false;
            this.btn_enviarFichero.FlatAppearance.BorderSize = 0;
            this.btn_enviarFichero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviarFichero.ForeColor = System.Drawing.Color.Aqua;
            this.btn_enviarFichero.Image = global::NauPACS.Properties.Resources.SpaceShip_ButtonTextureº;
            this.btn_enviarFichero.Location = new System.Drawing.Point(1511, 963);
            this.btn_enviarFichero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviarFichero.Name = "btn_enviarFichero";
            this.btn_enviarFichero.Size = new System.Drawing.Size(199, 85);
            this.btn_enviarFichero.TabIndex = 17;
            this.btn_enviarFichero.Text = "Enviar Fichero";
            this.btn_enviarFichero.UseVisualStyleBackColor = false;
            this.btn_enviarFichero.Click += new System.EventHandler(this.btn_enviarFichero_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Nau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.SkyBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Nau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSetBindingSource)).EndInit();
            this.SkyBackGround.ResumeLayout(false);
            this.SpaceShipBackGround.ResumeLayout(false);
            this.SpaceShipBackGround.PerformLayout();
            this.panel_MBtnTexture.ResumeLayout(false);
            this.panel_SDBtnTexture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pl_PlanetHolograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectToPlanetPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Delivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_enviarCV;
        private System.Windows.Forms.Button btn_conectar_servidor;
        private System.Windows.Forms.Button btn_desconectar_servidor;
        private System.Windows.Forms.ComboBox cmb_Nau;
        private System.Windows.Forms.Button btn_PlanetConnect;
        private System.Windows.Forms.Button btn_enviarFichero;
        private System.Windows.Forms.DataGridView dtg_Delivery;
        private pacsDataSet pacsDataSet;
        private System.Windows.Forms.BindingSource pacsDataSetBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel SkyBackGround;
        private System.Windows.Forms.Panel SpaceShipBackGround;
        private System.Windows.Forms.ListBox ConsoleBox1;
        private System.Windows.Forms.ListBox ConsoleBox2;
        private System.Windows.Forms.PictureBox ConnectedPB;
        private System.Windows.Forms.PictureBox AccessPB;
        private System.Windows.Forms.PictureBox ConnectToPlanetPB;
        private System.Windows.Forms.PictureBox Pl_PlanetHolograma;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_ShutDown;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Panel panel_MBtnTexture;
        private System.Windows.Forms.Panel panel_SDBtnTexture;
    }
}

