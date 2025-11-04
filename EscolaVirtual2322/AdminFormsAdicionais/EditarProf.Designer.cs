namespace EscolaVirtual2322.AdminFormsAdicionais
{
    partial class EditarProf
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblnif = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.txtNIF);
            this.panel1.Controls.Add(this.lblnif);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(39, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 276);
            this.panel1.TabIndex = 27;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblNome.Location = new System.Drawing.Point(27, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 22);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(31, 109);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(161, 22);
            this.txtPass.TabIndex = 24;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblpassword.Location = new System.Drawing.Point(27, 81);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(118, 22);
            this.lblpassword.TabIndex = 23;
            this.lblpassword.Text = "Password:";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInserir.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnInserir.Location = new System.Drawing.Point(31, 225);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(163, 28);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(216, 43);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(165, 22);
            this.txtLogin.TabIndex = 22;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblLogin.Location = new System.Drawing.Point(211, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(82, 22);
            this.lblLogin.TabIndex = 21;
            this.lblLogin.Text = "Login:";
            // 
            // txtNIF
            // 
            this.txtNIF.Enabled = false;
            this.txtNIF.Location = new System.Drawing.Point(31, 171);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(63, 22);
            this.txtNIF.TabIndex = 20;
            // 
            // lblnif
            // 
            this.lblnif.AutoSize = true;
            this.lblnif.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblnif.Location = new System.Drawing.Point(27, 143);
            this.lblnif.Name = "lblnif";
            this.lblnif.Size = new System.Drawing.Size(58, 22);
            this.lblnif.TabIndex = 19;
            this.lblnif.Text = "NIF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 43);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 22);
            this.txtNome.TabIndex = 18;
            // 
            // EditarProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(505, 351);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EditarProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Professor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblnif;
        private System.Windows.Forms.TextBox txtNome;
    }
}