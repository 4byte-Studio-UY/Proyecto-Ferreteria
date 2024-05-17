namespace Design
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.btnIngresoLog = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(216, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 243);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.txtPassLogin);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtEmailLogin);
            this.panel2.Controls.Add(this.btnIngresoLog);
            this.panel2.Location = new System.Drawing.Point(190, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 243);
            this.panel2.TabIndex = 1;
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtPassLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassLogin.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtPassLogin.Location = new System.Drawing.Point(73, 147);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.PasswordChar = '*';
            this.txtPassLogin.Size = new System.Drawing.Size(237, 22);
            this.txtPassLogin.TabIndex = 3;
            this.txtPassLogin.Text = "Ingrese Contraseña";
            this.txtPassLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLogin.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtEmailLogin.Location = new System.Drawing.Point(73, 110);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(237, 22);
            this.txtEmailLogin.TabIndex = 1;
            this.txtEmailLogin.Text = "Ingrese Token";
            this.txtEmailLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresoLog
            // 
            this.btnIngresoLog.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIngresoLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresoLog.Location = new System.Drawing.Point(122, 183);
            this.btnIngresoLog.Name = "btnIngresoLog";
            this.btnIngresoLog.Size = new System.Drawing.Size(142, 35);
            this.btnIngresoLog.TabIndex = 0;
            this.btnIngresoLog.Text = "Ingresar";
            this.btnIngresoLog.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.Button btnIngresoLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassLogin;
    }
}

