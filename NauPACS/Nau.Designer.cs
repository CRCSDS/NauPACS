
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
            this.DisconnectedPanel = new System.Windows.Forms.Panel();
            this.tbx_SendMessage = new System.Windows.Forms.TextBox();
            this.btn_enviarMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_obtenir_codi
            // 
            this.btn_obtenir_codi.Location = new System.Drawing.Point(27, 125);
            this.btn_obtenir_codi.Name = "btn_obtenir_codi";
            this.btn_obtenir_codi.Size = new System.Drawing.Size(124, 40);
            this.btn_obtenir_codi.TabIndex = 0;
            this.btn_obtenir_codi.Text = "Obtener CV";
            this.btn_obtenir_codi.UseVisualStyleBackColor = true;
            this.btn_obtenir_codi.Click += new System.EventHandler(this.btn_obtenir_codi_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(390, 16);
            this.btn_conectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(124, 40);
            this.btn_conectar.TabIndex = 1;
            this.btn_conectar.Text = "Conectar cliente";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_enviarCV
            // 
            this.btn_enviarCV.Location = new System.Drawing.Point(156, 125);
            this.btn_enviarCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviarCV.Name = "btn_enviarCV";
            this.btn_enviarCV.Size = new System.Drawing.Size(124, 40);
            this.btn_enviarCV.TabIndex = 2;
            this.btn_enviarCV.Text = "Enviar CV";
            this.btn_enviarCV.UseVisualStyleBackColor = true;
            this.btn_enviarCV.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(519, 16);
            this.btn_desconectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(162, 40);
            this.btn_desconectar.TabIndex = 3;
            this.btn_desconectar.Text = "Desconectar cliente";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // btn_conectar_servidor
            // 
            this.btn_conectar_servidor.Location = new System.Drawing.Point(390, 264);
            this.btn_conectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_conectar_servidor.Name = "btn_conectar_servidor";
            this.btn_conectar_servidor.Size = new System.Drawing.Size(134, 42);
            this.btn_conectar_servidor.TabIndex = 4;
            this.btn_conectar_servidor.Text = "Conectar servidor";
            this.btn_conectar_servidor.UseVisualStyleBackColor = true;
            this.btn_conectar_servidor.Click += new System.EventHandler(this.btn_conectar_servidor_Click);
            // 
            // btn_desconectar_servidor
            // 
            this.btn_desconectar_servidor.Location = new System.Drawing.Point(530, 264);
            this.btn_desconectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconectar_servidor.Name = "btn_desconectar_servidor";
            this.btn_desconectar_servidor.Size = new System.Drawing.Size(151, 42);
            this.btn_desconectar_servidor.TabIndex = 5;
            this.btn_desconectar_servidor.Text = "Desconectar servidor";
            this.btn_desconectar_servidor.UseVisualStyleBackColor = true;
            this.btn_desconectar_servidor.Click += new System.EventHandler(this.btn_desconectar_servidor_Click);
            // 
            // Msj_Recibido
            // 
            this.Msj_Recibido.Location = new System.Drawing.Point(390, 330);
            this.Msj_Recibido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Msj_Recibido.Multiline = true;
            this.Msj_Recibido.Name = "Msj_Recibido";
            this.Msj_Recibido.Size = new System.Drawing.Size(154, 22);
            this.Msj_Recibido.TabIndex = 6;
            // 
            // Control_operario
            // 
            this.Control_operario.AutoSize = true;
            this.Control_operario.Location = new System.Drawing.Point(387, 123);
            this.Control_operario.Name = "Control_operario";
            this.Control_operario.Size = new System.Drawing.Size(104, 17);
            this.Control_operario.TabIndex = 7;
            this.Control_operario.Text = "Sin especificar.";
            // 
            // cmb_Nau
            // 
            this.cmb_Nau.FormattingEnabled = true;
            this.cmb_Nau.Location = new System.Drawing.Point(66, 57);
            this.cmb_Nau.Name = "cmb_Nau";
            this.cmb_Nau.Size = new System.Drawing.Size(170, 24);
            this.cmb_Nau.TabIndex = 8;
            // 
            // txb_VCEncrypted
            // 
            this.txb_VCEncrypted.Location = new System.Drawing.Point(52, 216);
            this.txb_VCEncrypted.Name = "txb_VCEncrypted";
            this.txb_VCEncrypted.Size = new System.Drawing.Size(216, 22);
            this.txb_VCEncrypted.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo de validación Encriptado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccione su nave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Conexión:";
            // 
            // ConnectedPanel
            // 
            this.ConnectedPanel.BackColor = System.Drawing.Color.Gray;
            this.ConnectedPanel.Location = new System.Drawing.Point(390, 160);
            this.ConnectedPanel.Name = "ConnectedPanel";
            this.ConnectedPanel.Size = new System.Drawing.Size(27, 26);
            this.ConnectedPanel.TabIndex = 13;
            // 
            // DisconnectedPanel
            // 
            this.DisconnectedPanel.BackColor = System.Drawing.Color.Gray;
            this.DisconnectedPanel.Location = new System.Drawing.Point(423, 160);
            this.DisconnectedPanel.Name = "DisconnectedPanel";
            this.DisconnectedPanel.Size = new System.Drawing.Size(27, 26);
            this.DisconnectedPanel.TabIndex = 14;
            // 
            // tbx_SendMessage
            // 
            this.tbx_SendMessage.Location = new System.Drawing.Point(519, 125);
            this.tbx_SendMessage.Multiline = true;
            this.tbx_SendMessage.Name = "tbx_SendMessage";
            this.tbx_SendMessage.Size = new System.Drawing.Size(230, 100);
            this.tbx_SendMessage.TabIndex = 15;
            // 
            // btn_enviarMensaje
            // 
            this.btn_enviarMensaje.Location = new System.Drawing.Point(519, 94);
            this.btn_enviarMensaje.Name = "btn_enviarMensaje";
            this.btn_enviarMensaje.Size = new System.Drawing.Size(130, 23);
            this.btn_enviarMensaje.TabIndex = 16;
            this.btn_enviarMensaje.Text = "Enviar Mensaje";
            this.btn_enviarMensaje.UseVisualStyleBackColor = true;
            this.btn_enviarMensaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_enviarMensaje);
            this.Controls.Add(this.tbx_SendMessage);
            this.Controls.Add(this.DisconnectedPanel);
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
            this.Name = "Nau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nau";
            this.Load += new System.EventHandler(this.Nau_Load);
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
        private System.Windows.Forms.Panel DisconnectedPanel;
        private System.Windows.Forms.TextBox tbx_SendMessage;
        private System.Windows.Forms.Button btn_enviarMensaje;
    }
}

