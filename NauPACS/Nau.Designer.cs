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
            this.btn_obtenir_codi = new System.Windows.Forms.Button();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_enviarCV = new System.Windows.Forms.Button();
            this.btn_desconectar = new System.Windows.Forms.Button();
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
            this.btn_enviarMensaje = new System.Windows.Forms.Button();
            this.btn_enviarFichero = new System.Windows.Forms.Button();
            this.tbx_Fichero = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btn_tratarZip = new System.Windows.Forms.Button();
            this.dtg_Delivery = new System.Windows.Forms.DataGridView();
            this.pacsDataSet = new NauPACS.pacsDataSet();
            this.pacsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Delivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_obtenir_codi
            // 
            this.btn_obtenir_codi.Location = new System.Drawing.Point(30, 156);
            this.btn_obtenir_codi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_obtenir_codi.Name = "btn_obtenir_codi";
            this.btn_obtenir_codi.Size = new System.Drawing.Size(140, 50);
            this.btn_obtenir_codi.TabIndex = 0;
            this.btn_obtenir_codi.Text = "Obtener CV";
            this.btn_obtenir_codi.UseVisualStyleBackColor = true;
            this.btn_obtenir_codi.Click += new System.EventHandler(this.btn_obtenir_codi_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(439, 20);
            this.btn_conectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(140, 50);
            this.btn_conectar.TabIndex = 1;
            this.btn_conectar.Text = "Conectar cliente";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_enviarCV
            // 
            this.btn_enviarCV.Location = new System.Drawing.Point(176, 156);
            this.btn_enviarCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviarCV.Name = "btn_enviarCV";
            this.btn_enviarCV.Size = new System.Drawing.Size(140, 50);
            this.btn_enviarCV.TabIndex = 2;
            this.btn_enviarCV.Text = "Enviar CV";
            this.btn_enviarCV.UseVisualStyleBackColor = true;
            this.btn_enviarCV.Click += new System.EventHandler(this.btn_enviarCV_Click);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(584, 20);
            this.btn_desconectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(182, 50);
            this.btn_desconectar.TabIndex = 3;
            this.btn_desconectar.Text = "Desconectar cliente";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // btn_conectar_servidor
            // 
            this.btn_conectar_servidor.Location = new System.Drawing.Point(439, 330);
            this.btn_conectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_conectar_servidor.Name = "btn_conectar_servidor";
            this.btn_conectar_servidor.Size = new System.Drawing.Size(151, 52);
            this.btn_conectar_servidor.TabIndex = 4;
            this.btn_conectar_servidor.Text = "Conectar servidor";
            this.btn_conectar_servidor.UseVisualStyleBackColor = true;
            this.btn_conectar_servidor.Click += new System.EventHandler(this.btn_conectar_servidor_Click);
            // 
            // btn_desconectar_servidor
            // 
            this.btn_desconectar_servidor.Location = new System.Drawing.Point(596, 330);
            this.btn_desconectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconectar_servidor.Name = "btn_desconectar_servidor";
            this.btn_desconectar_servidor.Size = new System.Drawing.Size(170, 52);
            this.btn_desconectar_servidor.TabIndex = 5;
            this.btn_desconectar_servidor.Text = "Desconectar servidor";
            this.btn_desconectar_servidor.UseVisualStyleBackColor = true;
            this.btn_desconectar_servidor.Click += new System.EventHandler(this.btn_desconectar_servidor_Click);
            // 
            // Msj_Recibido
            // 
            this.Msj_Recibido.Location = new System.Drawing.Point(465, 444);
            this.Msj_Recibido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Msj_Recibido.Multiline = true;
            this.Msj_Recibido.Name = "Msj_Recibido";
            this.Msj_Recibido.Size = new System.Drawing.Size(241, 26);
            this.Msj_Recibido.TabIndex = 6;
            // 
            // Control_operario
            // 
            this.Control_operario.AutoSize = true;
            this.Control_operario.Location = new System.Drawing.Point(548, 186);
            this.Control_operario.Name = "Control_operario";
            this.Control_operario.Size = new System.Drawing.Size(116, 20);
            this.Control_operario.TabIndex = 7;
            this.Control_operario.Text = "Sin especificar.";
            // 
            // cmb_Nau
            // 
            this.cmb_Nau.FormattingEnabled = true;
            this.cmb_Nau.Location = new System.Drawing.Point(74, 71);
            this.cmb_Nau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Nau.Name = "cmb_Nau";
            this.cmb_Nau.Size = new System.Drawing.Size(191, 28);
            this.cmb_Nau.TabIndex = 8;
            this.cmb_Nau.SelectedIndexChanged += new System.EventHandler(this.cmb_Nau_SelectedIndexChanged);
            // 
            // txb_VCEncrypted
            // 
            this.txb_VCEncrypted.Location = new System.Drawing.Point(58, 270);
            this.txb_VCEncrypted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_VCEncrypted.Name = "txb_VCEncrypted";
            this.txb_VCEncrypted.Size = new System.Drawing.Size(242, 26);
            this.txb_VCEncrypted.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo de validación Encriptado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccione su nave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Conexión:";
            // 
            // ConnectedPanel
            // 
            this.ConnectedPanel.BackColor = System.Drawing.Color.Gray;
            this.ConnectedPanel.Location = new System.Drawing.Point(584, 231);
            this.ConnectedPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectedPanel.Name = "ConnectedPanel";
            this.ConnectedPanel.Size = new System.Drawing.Size(30, 32);
            this.ConnectedPanel.TabIndex = 13;
            // 
            // ConectplanetPanel
            // 
            this.ConectplanetPanel.BackColor = System.Drawing.Color.Gray;
            this.ConectplanetPanel.Location = new System.Drawing.Point(620, 231);
            this.ConectplanetPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConectplanetPanel.Name = "ConectplanetPanel";
            this.ConectplanetPanel.Size = new System.Drawing.Size(30, 32);
            this.ConectplanetPanel.TabIndex = 14;
            // 
            // btn_enviarMensaje
            // 
            this.btn_enviarMensaje.Location = new System.Drawing.Point(552, 132);
            this.btn_enviarMensaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_enviarMensaje.Name = "btn_enviarMensaje";
            this.btn_enviarMensaje.Size = new System.Drawing.Size(131, 29);
            this.btn_enviarMensaje.TabIndex = 16;
            this.btn_enviarMensaje.Text = "Enviar Mensaje";
            this.btn_enviarMensaje.UseVisualStyleBackColor = true;
            this.btn_enviarMensaje.Click += new System.EventHandler(this.btn_enviarMensaje_Click);
            // 
            // btn_enviarFichero
            // 
            this.btn_enviarFichero.Location = new System.Drawing.Point(176, 392);
            this.btn_enviarFichero.Name = "btn_enviarFichero";
            this.btn_enviarFichero.Size = new System.Drawing.Size(131, 29);
            this.btn_enviarFichero.TabIndex = 17;
            this.btn_enviarFichero.Text = "Enviar Fichero";
            this.btn_enviarFichero.UseVisualStyleBackColor = true;
            // 
            // tbx_Fichero
            // 
            this.tbx_Fichero.Location = new System.Drawing.Point(57, 444);
            this.tbx_Fichero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_Fichero.Name = "tbx_Fichero";
            this.tbx_Fichero.Size = new System.Drawing.Size(242, 26);
            this.tbx_Fichero.TabIndex = 18;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(439, 401);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(139, 20);
            this.lbl4.TabIndex = 19;
            this.lbl4.Text = "Mensaje Recibido:";
            // 
            // btn_tratarZip
            // 
            this.btn_tratarZip.Location = new System.Drawing.Point(39, 392);
            this.btn_tratarZip.Name = "btn_tratarZip";
            this.btn_tratarZip.Size = new System.Drawing.Size(131, 29);
            this.btn_tratarZip.TabIndex = 20;
            this.btn_tratarZip.Text = "Tratar Zip";
            this.btn_tratarZip.UseVisualStyleBackColor = true;
            this.btn_tratarZip.Click += new System.EventHandler(this.btn_tratarZip_Click);
            // 
            // dtg_Delivery
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_Delivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Delivery.Location = new System.Drawing.Point(386, 502);
            this.dtg_Delivery.Name = "dtg_Delivery";
            this.dtg_Delivery.RowHeadersWidth = 62;
            this.dtg_Delivery.RowTemplate.Height = 28;
            this.dtg_Delivery.Size = new System.Drawing.Size(709, 136);
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
            // Nau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 723);
            this.Controls.Add(this.dtg_Delivery);
            this.Controls.Add(this.btn_tratarZip);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.tbx_Fichero);
            this.Controls.Add(this.btn_enviarFichero);
            this.Controls.Add(this.btn_enviarMensaje);
            this.Controls.Add(this.ConectplanetPanel);
            this.Controls.Add(this.ConnectedPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_VCEncrypted);
            this.Controls.Add(this.cmb_Nau);
            this.Controls.Add(this.Control_operario);
            this.Controls.Add(this.Msj_Recibido);
            this.Controls.Add(this.btn_desconectar_servidor);
            this.Controls.Add(this.btn_conectar_servidor);
            this.Controls.Add(this.btn_desconectar);
            this.Controls.Add(this.btn_enviarCV);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.btn_obtenir_codi);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Nau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nau";
            this.Load += new System.EventHandler(this.Nau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Delivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_obtenir_codi;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_enviarCV;
        private System.Windows.Forms.Button btn_desconectar;
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
        private System.Windows.Forms.Button btn_enviarMensaje;
        private System.Windows.Forms.Button btn_enviarFichero;
        private System.Windows.Forms.TextBox tbx_Fichero;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btn_tratarZip;
        private System.Windows.Forms.DataGridView dtg_Delivery;
        private pacsDataSet pacsDataSet;
        private System.Windows.Forms.BindingSource pacsDataSetBindingSource;
    }
}

