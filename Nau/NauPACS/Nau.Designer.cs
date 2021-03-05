
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
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.btn_conectar_servidor = new System.Windows.Forms.Button();
            this.btn_desconectar_servidor = new System.Windows.Forms.Button();
            this.Msj_Recibido = new System.Windows.Forms.TextBox();
            this.Control_operario = new System.Windows.Forms.Label();
            this.cmb_Nau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_obtenir_codi
            // 
            this.btn_obtenir_codi.Location = new System.Drawing.Point(89, 65);
            this.btn_obtenir_codi.Name = "btn_obtenir_codi";
            this.btn_obtenir_codi.Size = new System.Drawing.Size(124, 40);
            this.btn_obtenir_codi.TabIndex = 0;
            this.btn_obtenir_codi.Text = "Obtenir Codi";
            this.btn_obtenir_codi.UseVisualStyleBackColor = true;
            this.btn_obtenir_codi.Click += new System.EventHandler(this.btn_obtenir_codi_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(90, 294);
            this.btn_conectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(124, 40);
            this.btn_conectar.TabIndex = 1;
            this.btn_conectar.Text = "Conectar Client";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(228, 65);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(124, 40);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(89, 355);
            this.btn_desconectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(125, 40);
            this.btn_desconectar.TabIndex = 3;
            this.btn_desconectar.Text = "Desconectar Client";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // btn_conectar_servidor
            // 
            this.btn_conectar_servidor.Location = new System.Drawing.Point(564, 292);
            this.btn_conectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_conectar_servidor.Name = "btn_conectar_servidor";
            this.btn_conectar_servidor.Size = new System.Drawing.Size(124, 42);
            this.btn_conectar_servidor.TabIndex = 4;
            this.btn_conectar_servidor.Text = "Conectar Servidor";
            this.btn_conectar_servidor.UseVisualStyleBackColor = true;
            this.btn_conectar_servidor.Click += new System.EventHandler(this.btn_conectar_servidor_Click);
            // 
            // btn_desconectar_servidor
            // 
            this.btn_desconectar_servidor.Location = new System.Drawing.Point(564, 355);
            this.btn_desconectar_servidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconectar_servidor.Name = "btn_desconectar_servidor";
            this.btn_desconectar_servidor.Size = new System.Drawing.Size(124, 40);
            this.btn_desconectar_servidor.TabIndex = 5;
            this.btn_desconectar_servidor.Text = "Desconectar Servidor";
            this.btn_desconectar_servidor.UseVisualStyleBackColor = true;
            this.btn_desconectar_servidor.Click += new System.EventHandler(this.btn_desconectar_servidor_Click);
            // 
            // Msj_Recibido
            // 
            this.Msj_Recibido.Location = new System.Drawing.Point(557, 241);
            this.Msj_Recibido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Msj_Recibido.Multiline = true;
            this.Msj_Recibido.Name = "Msj_Recibido";
            this.Msj_Recibido.Size = new System.Drawing.Size(142, 22);
            this.Msj_Recibido.TabIndex = 6;
            // 
            // Control_operario
            // 
            this.Control_operario.AutoSize = true;
            this.Control_operario.Location = new System.Drawing.Point(341, 379);
            this.Control_operario.Name = "Control_operario";
            this.Control_operario.Size = new System.Drawing.Size(46, 17);
            this.Control_operario.TabIndex = 7;
            this.Control_operario.Text = "label1";
            // 
            // cmb_Nau
            // 
            this.cmb_Nau.FormattingEnabled = true;
            this.cmb_Nau.Location = new System.Drawing.Point(439, 74);
            this.cmb_Nau.Name = "cmb_Nau";
            this.cmb_Nau.Size = new System.Drawing.Size(170, 24);
            this.cmb_Nau.TabIndex = 8;
            // 
            // Nau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_Nau);
            this.Controls.Add(this.Control_operario);
            this.Controls.Add(this.Msj_Recibido);
            this.Controls.Add(this.btn_desconectar_servidor);
            this.Controls.Add(this.btn_conectar_servidor);
            this.Controls.Add(this.btn_desconectar);
            this.Controls.Add(this.btn_enviar);
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
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Button btn_conectar_servidor;
        private System.Windows.Forms.Button btn_desconectar_servidor;
        private System.Windows.Forms.TextBox Msj_Recibido;
        private System.Windows.Forms.Label Control_operario;
        private System.Windows.Forms.ComboBox cmb_Nau;
    }
}

