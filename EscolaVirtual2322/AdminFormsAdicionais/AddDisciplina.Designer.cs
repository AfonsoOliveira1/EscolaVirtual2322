namespace EscolaVirtual2322.AdminFormsAdicionais
{
    partial class AddDisciplina
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
            this.lblSigla = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTurma
            // 
            this.cbbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTurma.FormattingEnabled = true;
            this.cbbTurma.Location = new System.Drawing.Point(205, 87);
            this.cbbTurma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTurma.Name = "cbbTurma";
            this.cbbTurma.Size = new System.Drawing.Size(122, 21);
            this.cbbTurma.TabIndex = 21;
            // 
            // cbbAnos
            // 
            this.cbbAnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnos.FormattingEnabled = true;
            this.cbbAnos.Location = new System.Drawing.Point(205, 46);
            this.cbbAnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbAnos.Name = "cbbAnos";
            this.cbbAnos.Size = new System.Drawing.Size(122, 21);
            this.cbbAnos.TabIndex = 20;
            this.cbbAnos.SelectedIndexChanged += new System.EventHandler(this.cbbAnos_SelectedIndexChanged);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblAno.Location = new System.Drawing.Point(13, 49);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(168, 18);
            this.lblAno.TabIndex = 19;
            this.lblAno.Text = "Selecione o Ano:";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInserir.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnInserir.Location = new System.Drawing.Point(16, 123);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(122, 23);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblTurma.Location = new System.Drawing.Point(13, 87);
            this.lblTurma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(188, 18);
            this.lblTurma.TabIndex = 17;
            this.lblTurma.Text = "Selecione a Turma:";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblSigla.Location = new System.Drawing.Point(208, 12);
            this.lblSigla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(68, 18);
            this.lblSigla.TabIndex = 22;
            this.lblSigla.Text = "Sigla:";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(280, 12);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSigla.MaxLength = 8;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(122, 20);
            this.txtSigla.TabIndex = 23;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblNome.Location = new System.Drawing.Point(13, 12);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 18);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 12);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(122, 20);
            this.txtNome.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.txtSigla);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Controls.Add(this.lblSigla);
            this.panel1.Controls.Add(this.cbbAnos);
            this.panel1.Controls.Add(this.cbbTurma);
            this.panel1.Location = new System.Drawing.Point(34, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 158);
            this.panel1.TabIndex = 26;
            // 
            // AddDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(555, 191);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AddDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Disciplina";
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
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
    }
}