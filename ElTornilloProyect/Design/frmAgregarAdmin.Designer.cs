namespace Design
{
    partial class frmAgregarAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAgNombreAdmin = new System.Windows.Forms.TextBox();
            this.txtAgTokenAdmin = new System.Windows.Forms.TextBox();
            this.txtAgContraAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAgContraAdmin);
            this.panel1.Controls.Add(this.txtAgTokenAdmin);
            this.panel1.Controls.Add(this.txtAgNombreAdmin);
            this.panel1.Location = new System.Drawing.Point(167, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 366);
            this.panel1.TabIndex = 0;
            // 
            // txtAgNombreAdmin
            // 
            this.txtAgNombreAdmin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAgNombreAdmin.Location = new System.Drawing.Point(105, 85);
            this.txtAgNombreAdmin.Name = "txtAgNombreAdmin";
            this.txtAgNombreAdmin.Size = new System.Drawing.Size(239, 20);
            this.txtAgNombreAdmin.TabIndex = 0;
            // 
            // txtAgTokenAdmin
            // 
            this.txtAgTokenAdmin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAgTokenAdmin.Location = new System.Drawing.Point(105, 148);
            this.txtAgTokenAdmin.Name = "txtAgTokenAdmin";
            this.txtAgTokenAdmin.Size = new System.Drawing.Size(239, 20);
            this.txtAgTokenAdmin.TabIndex = 1;
            // 
            // txtAgContraAdmin
            // 
            this.txtAgContraAdmin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAgContraAdmin.Location = new System.Drawing.Point(105, 211);
            this.txtAgContraAdmin.Name = "txtAgContraAdmin";
            this.txtAgContraAdmin.Size = new System.Drawing.Size(239, 20);
            this.txtAgContraAdmin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(75, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(193, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(196, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOKEN*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(173, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CONTRASEÑA*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(134, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Admin";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAgregarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgregarAdmin";
            this.Text = "frmAgregarAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgContraAdmin;
        private System.Windows.Forms.TextBox txtAgTokenAdmin;
        private System.Windows.Forms.TextBox txtAgNombreAdmin;
        private System.Windows.Forms.Button button1;
    }
}