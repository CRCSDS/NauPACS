
namespace PlanetaPACS
{
    partial class Form1
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
            this.btn_codi = new System.Windows.Forms.Button();
            this.cmb_Planeta = new System.Windows.Forms.ComboBox();
            this.btn_clau = new System.Windows.Forms.Button();
            this.btn_Servidor = new System.Windows.Forms.Button();
            this.btn_Desconectar = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.btn_DesconectarClient = new System.Windows.Forms.Button();
            this.lb_Missatges = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Missatge = new System.Windows.Forms.Label();
            this.btn_xifrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_codi
            // 
            this.btn_codi.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_codi.Location = new System.Drawing.Point(200, 51);
            this.btn_codi.Name = "btn_codi";
            this.btn_codi.Size = new System.Drawing.Size(114, 64);
            this.btn_codi.TabIndex = 0;
            this.btn_codi.Text = "Generar codi";
            this.btn_codi.UseVisualStyleBackColor = true;
            this.btn_codi.Click += new System.EventHandler(this.btn_codi_Click);
            // 
            // cmb_Planeta
            // 
            this.cmb_Planeta.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Planeta.FormattingEnabled = true;
            this.cmb_Planeta.Location = new System.Drawing.Point(40, 51);
            this.cmb_Planeta.Name = "cmb_Planeta";
            this.cmb_Planeta.Size = new System.Drawing.Size(140, 29);
            this.cmb_Planeta.Sorted = true;
            this.cmb_Planeta.TabIndex = 1;
            // 
            // btn_clau
            // 
            this.btn_clau.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clau.Location = new System.Drawing.Point(320, 51);
            this.btn_clau.Name = "btn_clau";
            this.btn_clau.Size = new System.Drawing.Size(114, 64);
            this.btn_clau.TabIndex = 2;
            this.btn_clau.Text = "Generar clau";
            this.btn_clau.UseVisualStyleBackColor = true;
            this.btn_clau.Click += new System.EventHandler(this.btn_clau_Click);
            // 
            // btn_Servidor
            // 
            this.btn_Servidor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Servidor.Location = new System.Drawing.Point(827, 34);
            this.btn_Servidor.Name = "btn_Servidor";
            this.btn_Servidor.Size = new System.Drawing.Size(140, 85);
            this.btn_Servidor.TabIndex = 4;
            this.btn_Servidor.Text = "Iniciar Servidor";
            this.btn_Servidor.UseVisualStyleBackColor = true;
            this.btn_Servidor.Click += new System.EventHandler(this.btn_Servidor_Click);
            // 
            // btn_Desconectar
            // 
            this.btn_Desconectar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Desconectar.Location = new System.Drawing.Point(827, 125);
            this.btn_Desconectar.Name = "btn_Desconectar";
            this.btn_Desconectar.Size = new System.Drawing.Size(140, 85);
            this.btn_Desconectar.TabIndex = 5;
            this.btn_Desconectar.Text = "Desconectar Servidor";
            this.btn_Desconectar.UseVisualStyleBackColor = true;
            this.btn_Desconectar.Click += new System.EventHandler(this.btn_Desconectar_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Client.Location = new System.Drawing.Point(827, 216);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(140, 85);
            this.btn_Client.TabIndex = 7;
            this.btn_Client.Text = "Iniciar Client";
            this.btn_Client.UseVisualStyleBackColor = true;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // btn_DesconectarClient
            // 
            this.btn_DesconectarClient.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DesconectarClient.Location = new System.Drawing.Point(827, 307);
            this.btn_DesconectarClient.Name = "btn_DesconectarClient";
            this.btn_DesconectarClient.Size = new System.Drawing.Size(140, 85);
            this.btn_DesconectarClient.TabIndex = 8;
            this.btn_DesconectarClient.Text = "Desconectar Client";
            this.btn_DesconectarClient.UseVisualStyleBackColor = true;
            this.btn_DesconectarClient.Click += new System.EventHandler(this.btn_DesconectarClient_Click);
            // 
            // lb_Missatges
            // 
            this.lb_Missatges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Missatges.FormattingEnabled = true;
            this.lb_Missatges.ItemHeight = 16;
            this.lb_Missatges.Location = new System.Drawing.Point(982, 34);
            this.lb_Missatges.Name = "lb_Missatges";
            this.lb_Missatges.Size = new System.Drawing.Size(400, 260);
            this.lb_Missatges.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(982, 331);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 61);
            this.textBox1.TabIndex = 10;
            // 
            // lbl_Missatge
            // 
            this.lbl_Missatge.AutoSize = true;
            this.lbl_Missatge.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Missatge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Missatge.Location = new System.Drawing.Point(978, 307);
            this.lbl_Missatge.Name = "lbl_Missatge";
            this.lbl_Missatge.Size = new System.Drawing.Size(75, 21);
            this.lbl_Missatge.TabIndex = 11;
            this.lbl_Missatge.Text = "Missatge";
            // 
            // btn_xifrat
            // 
            this.btn_xifrat.Font = new System.Drawing.Font("Corbel", 10.8F);
            this.btn_xifrat.Location = new System.Drawing.Point(200, 145);
            this.btn_xifrat.Name = "btn_xifrat";
            this.btn_xifrat.Size = new System.Drawing.Size(114, 65);
            this.btn_xifrat.TabIndex = 12;
            this.btn_xifrat.Text = "Generar Xifrat";
            this.btn_xifrat.UseVisualStyleBackColor = true;
            this.btn_xifrat.Click += new System.EventHandler(this.btn_xifrat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1412, 753);
            this.Controls.Add(this.btn_xifrat);
            this.Controls.Add(this.lbl_Missatge);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Missatges);
            this.Controls.Add(this.btn_DesconectarClient);
            this.Controls.Add(this.btn_Client);
            this.Controls.Add(this.btn_Desconectar);
            this.Controls.Add(this.btn_Servidor);
            this.Controls.Add(this.btn_clau);
            this.Controls.Add(this.cmb_Planeta);
            this.Controls.Add(this.btn_codi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanetaPACS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_codi;
        private System.Windows.Forms.ComboBox cmb_Planeta;
        private System.Windows.Forms.Button btn_clau;
        private System.Windows.Forms.Button btn_Servidor;
        private System.Windows.Forms.Button btn_Desconectar;
        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.Button btn_DesconectarClient;
        private System.Windows.Forms.ListBox lb_Missatges;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Missatge;
        private System.Windows.Forms.Button btn_xifrat;
    }
}

