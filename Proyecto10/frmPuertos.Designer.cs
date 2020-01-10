namespace Proyecto10
{
    partial class frmPuertos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuertos));
            this.lblPuertos = new System.Windows.Forms.Label();
            this.cboPuertos = new System.Windows.Forms.ComboBox();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.lblNpuerto = new System.Windows.Forms.Label();
            this.lblNbitStop = new System.Windows.Forms.Label();
            this.lblNbitParidad = new System.Windows.Forms.Label();
            this.cboVelocidad = new System.Windows.Forms.ComboBox();
            this.cboParidad = new System.Windows.Forms.ComboBox();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.cboBit = new System.Windows.Forms.ComboBox();
            this.btnArirPuerto = new System.Windows.Forms.Button();
            this.btnCerrarPuerto = new System.Windows.Forms.Button();
            this.erpPuertos = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnEnviarFichero = new System.Windows.Forms.Button();
            this.btnRecibirFichero = new System.Windows.Forms.Button();
            this.btnActivarChat = new System.Windows.Forms.Button();
            this.btnActivarTransferencia = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.erpPuertos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPuertos
            // 
            this.lblPuertos.AutoSize = true;
            this.lblPuertos.Location = new System.Drawing.Point(30, 38);
            this.lblPuertos.Name = "lblPuertos";
            this.lblPuertos.Size = new System.Drawing.Size(132, 17);
            this.lblPuertos.TabIndex = 0;
            this.lblPuertos.Text = "Puertos disponibles";
            // 
            // cboPuertos
            // 
            this.cboPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuertos.FormattingEnabled = true;
            this.cboPuertos.Location = new System.Drawing.Point(207, 35);
            this.cboPuertos.Name = "cboPuertos";
            this.cboPuertos.Size = new System.Drawing.Size(121, 24);
            this.cboPuertos.TabIndex = 1;
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(30, 93);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(70, 17);
            this.lblVelocidad.TabIndex = 2;
            this.lblVelocidad.Text = "Velocidad";
            // 
            // lblNpuerto
            // 
            this.lblNpuerto.AutoSize = true;
            this.lblNpuerto.Location = new System.Drawing.Point(30, 154);
            this.lblNpuerto.Name = "lblNpuerto";
            this.lblNpuerto.Size = new System.Drawing.Size(98, 17);
            this.lblNpuerto.TabIndex = 3;
            this.lblNpuerto.Text = "NoBit/carácter";
            // 
            // lblNbitStop
            // 
            this.lblNbitStop.AutoSize = true;
            this.lblNbitStop.Location = new System.Drawing.Point(30, 218);
            this.lblNbitStop.Name = "lblNbitStop";
            this.lblNbitStop.Size = new System.Drawing.Size(75, 17);
            this.lblNbitStop.TabIndex = 4;
            this.lblNbitStop.Text = "NoBit Stop";
            // 
            // lblNbitParidad
            // 
            this.lblNbitParidad.AutoSize = true;
            this.lblNbitParidad.Location = new System.Drawing.Point(30, 285);
            this.lblNbitParidad.Name = "lblNbitParidad";
            this.lblNbitParidad.Size = new System.Drawing.Size(95, 17);
            this.lblNbitParidad.TabIndex = 5;
            this.lblNbitParidad.Text = "NoBit Paridad";
            // 
            // cboVelocidad
            // 
            this.cboVelocidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVelocidad.FormattingEnabled = true;
            this.cboVelocidad.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "153600",
            "230400",
            "256000",
            "460800",
            "921600"});
            this.cboVelocidad.Location = new System.Drawing.Point(207, 93);
            this.cboVelocidad.Name = "cboVelocidad";
            this.cboVelocidad.Size = new System.Drawing.Size(121, 24);
            this.cboVelocidad.TabIndex = 6;
            // 
            // cboParidad
            // 
            this.cboParidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParidad.FormattingEnabled = true;
            this.cboParidad.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cboParidad.Location = new System.Drawing.Point(207, 282);
            this.cboParidad.Name = "cboParidad";
            this.cboParidad.Size = new System.Drawing.Size(121, 24);
            this.cboParidad.TabIndex = 7;
            // 
            // cboStop
            // 
            this.cboStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cboStop.Location = new System.Drawing.Point(207, 218);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(121, 24);
            this.cboStop.TabIndex = 8;
            // 
            // cboBit
            // 
            this.cboBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBit.FormattingEnabled = true;
            this.cboBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboBit.Location = new System.Drawing.Point(207, 154);
            this.cboBit.Name = "cboBit";
            this.cboBit.Size = new System.Drawing.Size(121, 24);
            this.cboBit.TabIndex = 9;
            // 
            // btnArirPuerto
            // 
            this.btnArirPuerto.Location = new System.Drawing.Point(125, 353);
            this.btnArirPuerto.Name = "btnArirPuerto";
            this.btnArirPuerto.Size = new System.Drawing.Size(105, 29);
            this.btnArirPuerto.TabIndex = 10;
            this.btnArirPuerto.Text = "Abrir Puerto";
            this.btnArirPuerto.UseVisualStyleBackColor = true;
            this.btnArirPuerto.Click += new System.EventHandler(this.btnArirPuerto_Click);
            // 
            // btnCerrarPuerto
            // 
            this.btnCerrarPuerto.Location = new System.Drawing.Point(125, 409);
            this.btnCerrarPuerto.Name = "btnCerrarPuerto";
            this.btnCerrarPuerto.Size = new System.Drawing.Size(105, 29);
            this.btnCerrarPuerto.TabIndex = 11;
            this.btnCerrarPuerto.Text = "Cerrar Puerto";
            this.btnCerrarPuerto.UseVisualStyleBackColor = true;
            this.btnCerrarPuerto.Click += new System.EventHandler(this.btnCerrarPuerto_Click);
            // 
            // erpPuertos
            // 
            this.erpPuertos.ContainerControl = this;
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(382, 321);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(230, 22);
            this.txtEnviar.TabIndex = 12;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(652, 321);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(382, 38);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(345, 268);
            this.txtChat.TabIndex = 14;
            // 
            // btnEnviarFichero
            // 
            this.btnEnviarFichero.Enabled = false;
            this.btnEnviarFichero.Location = new System.Drawing.Point(382, 353);
            this.btnEnviarFichero.Name = "btnEnviarFichero";
            this.btnEnviarFichero.Size = new System.Drawing.Size(125, 29);
            this.btnEnviarFichero.TabIndex = 15;
            this.btnEnviarFichero.Text = "Enviar Fichero";
            this.btnEnviarFichero.UseVisualStyleBackColor = true;
            this.btnEnviarFichero.Click += new System.EventHandler(this.btnEnviarFichero_Click);
            // 
            // btnRecibirFichero
            // 
            this.btnRecibirFichero.Enabled = false;
            this.btnRecibirFichero.Location = new System.Drawing.Point(577, 353);
            this.btnRecibirFichero.Name = "btnRecibirFichero";
            this.btnRecibirFichero.Size = new System.Drawing.Size(150, 29);
            this.btnRecibirFichero.TabIndex = 16;
            this.btnRecibirFichero.Text = "Recibir Fichero";
            this.btnRecibirFichero.UseVisualStyleBackColor = true;
            this.btnRecibirFichero.Click += new System.EventHandler(this.btnRecibirFichero_Click);
            // 
            // btnActivarChat
            // 
            this.btnActivarChat.Location = new System.Drawing.Point(382, 409);
            this.btnActivarChat.Name = "btnActivarChat";
            this.btnActivarChat.Size = new System.Drawing.Size(125, 29);
            this.btnActivarChat.TabIndex = 17;
            this.btnActivarChat.Text = "Activar chat";
            this.btnActivarChat.UseVisualStyleBackColor = true;
            this.btnActivarChat.Click += new System.EventHandler(this.btnActivarChat_Click);
            // 
            // btnActivarTransferencia
            // 
            this.btnActivarTransferencia.Location = new System.Drawing.Point(577, 409);
            this.btnActivarTransferencia.Name = "btnActivarTransferencia";
            this.btnActivarTransferencia.Size = new System.Drawing.Size(150, 28);
            this.btnActivarTransferencia.TabIndex = 18;
            this.btnActivarTransferencia.Text = "Activar ficheros";
            this.btnActivarTransferencia.UseVisualStyleBackColor = true;
            this.btnActivarTransferencia.Click += new System.EventHandler(this.btnActivarTransferencia_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmPuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 472);
            this.Controls.Add(this.btnActivarTransferencia);
            this.Controls.Add(this.btnActivarChat);
            this.Controls.Add(this.btnRecibirFichero);
            this.Controls.Add(this.btnEnviarFichero);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.btnCerrarPuerto);
            this.Controls.Add(this.btnArirPuerto);
            this.Controls.Add(this.cboBit);
            this.Controls.Add(this.cboStop);
            this.Controls.Add(this.cboParidad);
            this.Controls.Add(this.cboVelocidad);
            this.Controls.Add(this.lblNbitParidad);
            this.Controls.Add(this.lblNbitStop);
            this.Controls.Add(this.lblNpuerto);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.cboPuertos);
            this.Controls.Add(this.lblPuertos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPuertos";
            this.Text = "Manejo puertos serie";
            this.Load += new System.EventHandler(this.frmPuertos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpPuertos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPuertos;
        private System.Windows.Forms.ComboBox cboPuertos;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label lblNpuerto;
        private System.Windows.Forms.Label lblNbitStop;
        private System.Windows.Forms.Label lblNbitParidad;
        private System.Windows.Forms.ComboBox cboVelocidad;
        private System.Windows.Forms.ComboBox cboParidad;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.ComboBox cboBit;
        private System.Windows.Forms.Button btnArirPuerto;
        private System.Windows.Forms.Button btnCerrarPuerto;
        private System.Windows.Forms.ErrorProvider erpPuertos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEnviar;
        public System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnRecibirFichero;
        private System.Windows.Forms.Button btnEnviarFichero;
        private System.Windows.Forms.Button btnActivarTransferencia;
        private System.Windows.Forms.Button btnActivarChat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

