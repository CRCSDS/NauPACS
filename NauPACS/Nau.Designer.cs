﻿
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
            this.pacsDataSet = new NauPACS.pacsDataSet();
            this.pacsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SkyBackGround = new System.Windows.Forms.Panel();
            this.SpaceShipBackGround = new System.Windows.Forms.Panel();
            this.Pl_PlanetHolograma = new System.Windows.Forms.PictureBox();
            this.AccessPB = new System.Windows.Forms.PictureBox();
            this.ConnectToPlanetPB = new System.Windows.Forms.PictureBox();
            this.ConnectedPB = new System.Windows.Forms.PictureBox();
            this.ConsoleBox2 = new System.Windows.Forms.ListBox();
            this.cmb_Nau = new System.Windows.Forms.ComboBox();
            this.dtg_Delivery = new System.Windows.Forms.DataGridView();
            this.ConsoleBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PlanetConnect = new System.Windows.Forms.Button();
            this.btn_enviarCV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_desconectar_servidor = new System.Windows.Forms.Button();
            this.btn_conectar_servidor = new System.Windows.Forms.Button();
            this.btn_enviarFichero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSetBindingSource)).BeginInit();
            this.SkyBackGround.SuspendLayout();
            this.SpaceShipBackGround.SuspendLayout();
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
            this.SkyBackGround.Size = new System.Drawing.Size(1920, 1080);
            this.SkyBackGround.TabIndex = 25;
            // 
            // SpaceShipBackGround
            // 
            this.SpaceShipBackGround.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShipBackGround.BackgroundImage = global::NauPACS.Properties.Resources.spaceship_hud_rs2;
            this.SpaceShipBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpaceShipBackGround.Controls.Add(this.Pl_PlanetHolograma);
            this.SpaceShipBackGround.Controls.Add(this.AccessPB);
            this.SpaceShipBackGround.Controls.Add(this.ConnectToPlanetPB);
            this.SpaceShipBackGround.Controls.Add(this.ConnectedPB);
            this.SpaceShipBackGround.Controls.Add(this.ConsoleBox2);
            this.SpaceShipBackGround.Controls.Add(this.cmb_Nau);
            this.SpaceShipBackGround.Controls.Add(this.dtg_Delivery);
            this.SpaceShipBackGround.Controls.Add(this.ConsoleBox1);
            this.SpaceShipBackGround.Controls.Add(this.label2);
            this.SpaceShipBackGround.Controls.Add(this.btn_PlanetConnect);
            this.SpaceShipBackGround.Controls.Add(this.btn_enviarCV);
            this.SpaceShipBackGround.Controls.Add(this.label5);
            this.SpaceShipBackGround.Controls.Add(this.btn_desconectar_servidor);
            this.SpaceShipBackGround.Controls.Add(this.btn_conectar_servidor);
            this.SpaceShipBackGround.Controls.Add(this.btn_enviarFichero);
            this.SpaceShipBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpaceShipBackGround.Location = new System.Drawing.Point(0, 0);
            this.SpaceShipBackGround.Name = "SpaceShipBackGround";
            this.SpaceShipBackGround.Size = new System.Drawing.Size(1920, 1080);
            this.SpaceShipBackGround.TabIndex = 25;
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
            this.cmb_Nau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Nau.ForeColor = System.Drawing.Color.Aqua;
            this.cmb_Nau.FormattingEnabled = true;
            this.cmb_Nau.Location = new System.Drawing.Point(918, 571);
            this.cmb_Nau.Name = "cmb_Nau";
            this.cmb_Nau.Size = new System.Drawing.Size(170, 24);
            this.cmb_Nau.TabIndex = 8;
            this.cmb_Nau.SelectedIndexChanged += new System.EventHandler(this.cmb_Nau_SelectedIndexChanged);
            // 
            // dtg_Delivery
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_Delivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Delivery.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_Delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Delivery.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_Delivery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtg_Delivery.Location = new System.Drawing.Point(839, 600);
            this.dtg_Delivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_Delivery.Name = "dtg_Delivery";
            this.dtg_Delivery.ReadOnly = true;
            this.dtg_Delivery.RowHeadersWidth = 62;
            this.dtg_Delivery.RowTemplate.Height = 28;
            this.dtg_Delivery.Size = new System.Drawing.Size(332, 85);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(873, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "SELECCION DE NAVE";
            // 
            // btn_PlanetConnect
            // 
            this.btn_PlanetConnect.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlanetConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_PlanetConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlanetConnect.FlatAppearance.BorderSize = 0;
            this.btn_PlanetConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlanetConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_enviarCV.Location = new System.Drawing.Point(1241, 963);
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
            this.btn_desconectar_servidor.ForeColor = System.Drawing.Color.Aqua;
            this.btn_desconectar_servidor.Image = global::NauPACS.Properties.Resources.SpaceShip_ButtonTextureº;
            this.btn_desconectar_servidor.Location = new System.Drawing.Point(601, 948);
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
            this.btn_conectar_servidor.Location = new System.Drawing.Point(388, 948);
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
            this.btn_enviarFichero.Location = new System.Drawing.Point(1460, 963);
            this.btn_enviarFichero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviarFichero.Name = "btn_enviarFichero";
            this.btn_enviarFichero.Size = new System.Drawing.Size(199, 85);
            this.btn_enviarFichero.TabIndex = 17;
            this.btn_enviarFichero.Text = "Enviar Fichero";
            this.btn_enviarFichero.UseVisualStyleBackColor = false;
            this.btn_enviarFichero.Click += new System.EventHandler(this.btn_enviarFichero_Click);
            // 
            // Nau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
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
        private System.Windows.Forms.Label label2;
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
    }
}

