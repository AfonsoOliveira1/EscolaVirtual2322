namespace EscolaVirtual2322.AdminFormsAdicionais
{
    partial class AddProf
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
            this.cbbTurma = new System.Windows.Forms.ComboBox();
            this.cbbAnos = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cbbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnColocar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblnif = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTurma
            // 
            this.cbbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTurma.FormattingEnabled = true;
            this.cbbTurma.Location = new System.Drawing.Point(270, 154);
            this.cbbTurma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTurma.Name = "cbbTurma";
            this.cbbTurma.Size = new System.Drawing.Size(122, 21);
            this.cbbTurma.TabIndex = 21;
            this.cbbTurma.SelectedIndexChanged += new System.EventHandler(this.cbbTurma_SelectedIndexChanged);
            // 
            // cbbAnos
            // 
            this.cbbAnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnos.FormattingEnabled = true;
            this.cbbAnos.Location = new System.Drawing.Point(270, 115);
            this.cbbAnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbAnos.Name = "cbbAnos";
            this.cbbAnos.Size = new System.Drawing.Size(122, 21);
            this.cbbAnos.TabIndex = 20;
            this.cbbAnos.SelectedIndexChanged += new System.EventHandler(this.cbbAnos_SelectedIndexChanged_1);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblAno.Location = new System.Drawing.Point(26, 115);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(168, 18);
            this.lblAno.TabIndex = 19;
            this.lblAno.Text = "Selecione o Ano:";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInserir.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnInserir.Location = new System.Drawing.Point(414, 191);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(165, 23);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblTurma.Location = new System.Drawing.Point(26, 153);
            this.lblTurma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(188, 18);
            this.lblTurma.TabIndex = 17;
            this.lblTurma.Text = "Selecione a Turma:";
            // 
            // cbbDisciplina
            // 
            this.cbbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDisciplina.FormattingEnabled = true;
            this.cbbDisciplina.Location = new System.Drawing.Point(270, 191);
            this.cbbDisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDisciplina.Name = "cbbDisciplina";
            this.cbbDisciplina.Size = new System.Drawing.Size(122, 21);
            this.cbbDisciplina.TabIndex = 23;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblDisciplina.Location = new System.Drawing.Point(26, 191);
            this.lblDisciplina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(238, 18);
            this.lblDisciplina.TabIndex = 22;
            this.lblDisciplina.Text = "Selecione a Disciplina:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(297, 41);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(122, 20);
            this.txtPass.TabIndex = 32;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblpassword.Location = new System.Drawing.Point(294, 18);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(98, 18);
            this.lblpassword.TabIndex = 31;
            this.lblpassword.Text = "Password:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(168, 41);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(122, 20);
            this.txtLogin.TabIndex = 30;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblLogin.Location = new System.Drawing.Point(164, 18);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(68, 18);
            this.lblLogin.TabIndex = 29;
            this.lblLogin.Text = "Login:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 41);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(122, 20);
            this.txtNome.TabIndex = 26;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblNome.Location = new System.Drawing.Point(26, 18);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 18);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome:";
            // 
            // btnColocar
            // 
            this.btnColocar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnColocar.Font = new System.Drawing.Font("Courier New", 8F);
            this.btnColocar.Location = new System.Drawing.Point(414, 145);
            this.btnColocar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColocar.Name = "btnColocar";
            this.btnColocar.Size = new System.Drawing.Size(165, 37);
            this.btnColocar.TabIndex = 33;
            this.btnColocar.Text = "Adicionar Disciplina  ao Professor";
            this.btnColocar.UseVisualStyleBackColor = false;
            this.btnColocar.Click += new System.EventHandler(this.btnColocar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtNIF);
            this.panel1.Controls.Add(this.lblnif);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.btnColocar);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.cbbAnos);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.cbbTurma);
            this.panel1.Controls.Add(this.lblDisciplina);
            this.panel1.Controls.Add(this.cbbDisciplina);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(35, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 239);
            this.panel1.TabIndex = 34;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(30, 84);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(80, 20);
            this.txtNIF.TabIndex = 35;
            // 
            // lblnif
            // 
            this.lblnif.AutoSize = true;
            this.lblnif.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblnif.Location = new System.Drawing.Point(26, 61);
            this.lblnif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnif.Name = "lblnif";
            this.lblnif.Size = new System.Drawing.Size(48, 18);
            this.lblnif.TabIndex = 34;
            this.lblnif.Text = "NIF:";
            // 
            // AddProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(687, 297);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AddProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Professor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTurma;
        private System.Windows.Forms.ComboBox cbbAnos;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cbbDisciplina;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnColocar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblnif;
    }
}