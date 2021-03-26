
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nau));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_enviarCV = new System.Windows.Forms.Button();
            this.btn_conectar_servidor = new System.Windows.Forms.Button();
            this.btn_desconectar_servidor = new System.Windows.Forms.Button();
            this.Msj_Recibido = new System.Windows.Forms.TextBox();
            this.Control_operario = new System.Windows.Forms.Label();
            this.cmb_Nau = new System.Windows.Forms.ComboBox();
            this.txb_VCEncrypted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectedPanel = new System.Windows.Forms.Panel();
            this.ConectplanetPanel = new System.Windows.Forms.Panel();
            this.btn_PlanetConnect = new System.Windows.Forms.Button();
            this.btn_enviarFichero = new System.Windows.Forms.Button();
            this.tbx_Fichero = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.dtg_Delivery = new System.Windows.Forms.DataGridView();
            this.pacsDataSet = new NauPACS.pacsDataSet();
            this.pacsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Control_operario_planeta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Delivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_enviarCV
            // 
            this.btn_enviarCV.BackColor = System.Drawing.Color.Gray;
            this.btn_enviarCV.ForeColor = System.Drawing.Color.White;
            this.btn_enviarCV.Location = new System.Drawing.Point(177, 842);
            this.btn_enviarCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviarCV.Name = "btn_enviarCV";
            this.btn_enviarCV.Size = new System.Drawing.Size(124, 40);
            this.btn_enviarCV.TabIndex = 2;
            this.btn_enviarCV.Text = "Enviar CV";
            this.btn_enviarCV.UseVisualStyleBackColor = false;
            this.btn_enviarCV.Click += new System.EventHandler(this.btn_enviarCV_Click);
            // 
            // btn_conectar_servidor
            // 
            this.btn_conectar_servidor.BackColor = System.Drawing.Color.Gray;
            this.btn_conectar_servidor.Enabled = false;
            this.btn_conectar_servidor.ForeColor = System.Drawing.Color.White;
            this.btn_conectar_servidor.Location = new System.Drawing.Point(570, 694);
            this.btn_conectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_conectar_servidor.Name = "btn_conectar_servidor";
            this.btn_conectar_servidor.Size = new System.Drawing.Size(151, 42);
            this.btn_conectar_servidor.TabIndex = 4;
            this.btn_conectar_servidor.Text = "Conectar servidor";
            this.btn_conectar_servidor.UseVisualStyleBackColor = false;
            this.btn_conectar_servidor.Click += new System.EventHandler(this.btn_conectar_servidor_Click);
            // 
            // btn_desconectar_servidor
            // 
            this.btn_desconectar_servidor.BackColor = System.Drawing.Color.Gray;
            this.btn_desconectar_servidor.Enabled = false;
            this.btn_desconectar_servidor.ForeColor = System.Drawing.Color.White;
            this.btn_desconectar_servidor.Location = new System.Drawing.Point(687, 964);
            this.btn_desconectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconectar_servidor.Name = "btn_desconectar_servidor";
            this.btn_desconectar_servidor.Size = new System.Drawing.Size(151, 42);
            this.btn_desconectar_servidor.TabIndex = 5;
            this.btn_desconectar_servidor.Text = "Desconectar servidor";
            this.btn_desconectar_servidor.UseVisualStyleBackColor = false;
            this.btn_desconectar_servidor.Click += new System.EventHandler(this.btn_desconectar_servidor_Click);
            // 
            // Msj_Recibido
            // 
            this.Msj_Recibido.Location = new System.Drawing.Point(177, 406);
            this.Msj_Recibido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Msj_Recibido.Multiline = true;
            this.Msj_Recibido.Name = "Msj_Recibido";
            this.Msj_Recibido.Size = new System.Drawing.Size(215, 22);
            this.Msj_Recibido.TabIndex = 6;
            // 
            // Control_operario
            // 
            this.Control_operario.AutoSize = true;
            this.Control_operario.BackColor = System.Drawing.Color.White;
            this.Control_operario.Location = new System.Drawing.Point(824, 787);
            this.Control_operario.Name = "Control_operario";
            this.Control_operario.Size = new System.Drawing.Size(104, 17);
            this.Control_operario.TabIndex = 7;
            this.Control_operario.Text = "Sin especificar.";
            // 
            // cmb_Nau
            // 
            this.cmb_Nau.FormattingEnabled = true;
            this.cmb_Nau.Location = new System.Drawing.Point(862, 602);
            this.cmb_Nau.Name = "cmb_Nau";
            this.cmb_Nau.Size = new System.Drawing.Size(170, 24);
            this.cmb_Nau.TabIndex = 8;
            this.cmb_Nau.SelectedIndexChanged += new System.EventHandler(this.cmb_Nau_SelectedIndexChanged);
            // 
            // txb_VCEncrypted
            // 
            this.txb_VCEncrypted.Location = new System.Drawing.Point(131, 815);
            this.txb_VCEncrypted.Name = "txb_VCEncrypted";
            this.txb_VCEncrypted.Size = new System.Drawing.Size(216, 22);
            this.txb_VCEncrypted.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 795);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo de validación Encriptado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(822, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "SELECCION DE NAVE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(602, 787);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Conexión a internet:";
            // 
            // ConnectedPanel
            // 
            this.ConnectedPanel.BackColor = System.Drawing.Color.Gray;
            this.ConnectedPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConnectedPanel.BackgroundImage")));
            this.ConnectedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConnectedPanel.Location = new System.Drawing.Point(768, 787);
            this.ConnectedPanel.Name = "ConnectedPanel";
            this.ConnectedPanel.Size = new System.Drawing.Size(42, 17);
            this.ConnectedPanel.TabIndex = 13;
            // 
            // ConectplanetPanel
            // 
            this.ConectplanetPanel.BackColor = System.Drawing.Color.Gray;
            this.ConectplanetPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConectplanetPanel.BackgroundImage")));
            this.ConectplanetPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConectplanetPanel.Location = new System.Drawing.Point(768, 820);
            this.ConectplanetPanel.Name = "ConectplanetPanel";
            this.ConectplanetPanel.Size = new System.Drawing.Size(42, 17);
            this.ConectplanetPanel.TabIndex = 14;
            // 
            // btn_PlanetConnect
            // 
            this.btn_PlanetConnect.BackColor = System.Drawing.Color.Gray;
            this.btn_PlanetConnect.ForeColor = System.Drawing.Color.White;
            this.btn_PlanetConnect.Location = new System.Drawing.Point(570, 631);
            this.btn_PlanetConnect.Name = "btn_PlanetConnect";
            this.btn_PlanetConnect.Size = new System.Drawing.Size(151, 40);
            this.btn_PlanetConnect.TabIndex = 16;
            this.btn_PlanetConnect.Text = "Conectar a planeta";
            this.btn_PlanetConnect.UseVisualStyleBackColor = false;
            this.btn_PlanetConnect.Click += new System.EventHandler(this.btn_PlanetConnect_Click);
            // 
            // btn_enviarFichero
            // 
            this.btn_enviarFichero.BackColor = System.Drawing.Color.Black;
            this.btn_enviarFichero.ForeColor = System.Drawing.Color.White;
            this.btn_enviarFichero.Location = new System.Drawing.Point(399, 815);
            this.btn_enviarFichero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviarFichero.Name = "btn_enviarFichero";
            this.btn_enviarFichero.Size = new System.Drawing.Size(121, 40);
            this.btn_enviarFichero.TabIndex = 17;
            this.btn_enviarFichero.Text = "Enviar Fichero";
            this.btn_enviarFichero.UseVisualStyleBackColor = false;
            this.btn_enviarFichero.Click += new System.EventHandler(this.btn_enviarFichero_Click);
            // 
            // tbx_Fichero
            // 
            this.tbx_Fichero.Location = new System.Drawing.Point(373, 795);
            this.tbx_Fichero.Name = "tbx_Fichero";
            this.tbx_Fichero.Size = new System.Drawing.Size(169, 22);
            this.tbx_Fichero.TabIndex = 18;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(174, 387);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(124, 17);
            this.lbl4.TabIndex = 19;
            this.lbl4.Text = "Mensaje Recibido:";
            // 
            // dtg_Delivery
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_Delivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Delivery.Location = new System.Drawing.Point(783, 631);
            this.dtg_Delivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_Delivery.Name = "dtg_Delivery";
            this.dtg_Delivery.RowHeadersWidth = 62;
            this.dtg_Delivery.RowTemplate.Height = 28;
            this.dtg_Delivery.Size = new System.Drawing.Size(332, 117);
            this.dtg_Delivery.TabIndex = 21;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(603, 818);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Conexión a planeta:";
            // 
            // Control_operario_planeta
            // 
            this.Control_operario_planeta.AutoSize = true;
            this.Control_operario_planeta.BackColor = System.Drawing.Color.White;
            this.Control_operario_planeta.Location = new System.Drawing.Point(824, 818);
            this.Control_operario_planeta.Name = "Control_operario_planeta";
            this.Control_operario_planeta.Size = new System.Drawing.Size(104, 17);
            this.Control_operario_planeta.TabIndex = 23;
            this.Control_operario_planeta.Text = "Sin especificar.";
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
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Msj_Recibido);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.dtg_Delivery);
            this.panel1.Controls.Add(this.cmb_Nau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txb_VCEncrypted);
            this.panel1.Controls.Add(this.btn_enviarCV);
            this.panel1.Controls.Add(this.btn_desconectar_servidor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::NauPACS.Properties.Resources.SpaceShip_HUDv1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.ConectplanetPanel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_PlanetConnect);
            this.panel2.Controls.Add(this.tbx_Fichero);
            this.panel2.Controls.Add(this.Control_operario_planeta);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_conectar_servidor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_enviarFichero);
            this.panel2.Controls.Add(this.ConnectedPanel);
            this.panel2.Controls.Add(this.Control_operario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 1080);
            this.panel2.TabIndex = 25;
            // 
            // Nau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Nau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Delivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_enviarCV;
        private System.Windows.Forms.Button btn_conectar_servidor;
        private System.Windows.Forms.Button btn_desconectar_servidor;
        private System.Windows.Forms.TextBox Msj_Recibido;
        private System.Windows.Forms.Label Control_operario;
        private System.Windows.Forms.ComboBox cmb_Nau;
        private System.Windows.Forms.TextBox txb_VCEncrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ConnectedPanel;
        private System.Windows.Forms.Panel ConectplanetPanel;
        private System.Windows.Forms.Button btn_PlanetConnect;
        private System.Windows.Forms.Button btn_enviarFichero;
        private System.Windows.Forms.TextBox tbx_Fichero;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.DataGridView dtg_Delivery;
        private pacsDataSet pacsDataSet;
        private System.Windows.Forms.BindingSource pacsDataSetBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Control_operario_planeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

