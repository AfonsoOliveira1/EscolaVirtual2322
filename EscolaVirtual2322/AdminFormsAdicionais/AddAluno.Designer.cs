namespace EscolaVirtual2322.AdminFormsAdicionais
{
    partial class AddAluno
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
            this.cbbAnos = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cbbTurma = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblnif = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbAnos
            // 
            this.cbbAnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnos.FormattingEnabled = true;
            this.cbbAnos.Location = new System.Drawing.Point(283, 137);
            this.cbbAnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAnos.Name = "cbbAnos";
            this.cbbAnos.Size = new System.Drawing.Size(161, 24);
            this.cbbAnos.TabIndex = 15;
            this.cbbAnos.SelectedIndexChanged += new System.EventHandler(this.cbbAnos_SelectedIndexChanged);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblAno.Location = new System.Drawing.Point(27, 140);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(202, 22);
            this.lblAno.TabIndex = 14;
            this.lblAno.Text = "Selecione o Ano:";
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
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblTurma.Location = new System.Drawing.Point(27, 187);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(226, 22);
            this.lblTurma.TabIndex = 11;
            this.lblTurma.Text = "Selecione a Turma:";
            // 
            // cbbTurma
            // 
            this.cbbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTurma.FormattingEnabled = true;
            this.cbbTurma.Location = new System.Drawing.Point(283, 187);
            this.cbbTurma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTurma.Name = "cbbTurma";
            this.cbbTurma.Size = new System.Drawing.Size(161, 24);
            this.cbbTurma.TabIndex = 16;
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 43);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 22);
            this.txtNome.TabIndex = 18;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblnum.Location = new System.Drawing.Point(28, 70);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(130, 22);
            this.lblnum.TabIndex = 19;
            this.lblnum.Text = "Num Aluno:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(32, 98);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum.MaxLength = 9;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(88, 22);
            this.txtNum.TabIndex = 20;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
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
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(216, 43);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(165, 22);
            this.txtLogin.TabIndex = 22;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(388, 43);
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
            this.lblpassword.Location = new System.Drawing.Point(384, 15);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(118, 22);
            this.lblpassword.TabIndex = 23;
            this.lblpassword.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtNIF);
            this.panel1.Controls.Add(this.lblnif);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.cbbAnos);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.cbbTurma);
            this.panel1.Controls.Add(this.lblnum);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(43, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 276);
            this.panel1.TabIndex = 25;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(180, 98);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(63, 22);
            this.txtNIF.TabIndex = 26;
            this.txtNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIF_KeyPress);
            // 
            // lblnif
            // 
            this.lblnif.AutoSize = true;
            this.lblnif.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblnif.Location = new System.Drawing.Point(177, 70);
            this.lblnif.Name = "lblnif";
            this.lblnif.Size = new System.Drawing.Size(58, 22);
            this.lblnif.TabIndex = 25;
            this.lblnif.Text = "NIF:";
            // 
            // AddAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(665, 337);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbAnos;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cbbTurma;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblnif;
    }
}