namespace EscolaVirtual2322.AdminFormsAdicionais
{
    partial class DisciplinaProf
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
            this.cbbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.cbbTurma = new System.Windows.Forms.ComboBox();
            this.cbbAnos = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.cbbProf = new System.Windows.Forms.ComboBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbDisciplina
            // 
            this.cbbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDisciplina.FormattingEnabled = true;
            this.cbbDisciplina.Location = new System.Drawing.Point(255, 88);
            this.cbbDisciplina.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDisciplina.Name = "cbbDisciplina";
            this.cbbDisciplina.Size = new System.Drawing.Size(122, 21);
            this.cbbDisciplina.TabIndex = 29;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblDisciplina.Location = new System.Drawing.Point(17, 88);
            this.lblDisciplina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(238, 18);
            this.lblDisciplina.TabIndex = 28;
            this.lblDisciplina.Text = "Selecione a Disciplina:";
            // 
            // cbbTurma
            // 
            this.cbbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTurma.FormattingEnabled = true;
            this.cbbTurma.Location = new System.Drawing.Point(255, 53);
            this.cbbTurma.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTurma.Name = "cbbTurma";
            this.cbbTurma.Size = new System.Drawing.Size(122, 21);
            this.cbbTurma.TabIndex = 27;
            this.cbbTurma.SelectedIndexChanged += new System.EventHandler(this.cbbTurma_SelectedIndexChanged);
            // 
            // cbbAnos
            // 
            this.cbbAnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnos.FormattingEnabled = true;
            this.cbbAnos.Location = new System.Drawing.Point(255, 12);
            this.cbbAnos.Margin = new System.Windows.Forms.Padding(2);
            this.cbbAnos.Name = "cbbAnos";
            this.cbbAnos.Size = new System.Drawing.Size(122, 21);
            this.cbbAnos.TabIndex = 26;
            this.cbbAnos.SelectedIndexChanged += new System.EventHandler(this.cbbAnos_SelectedIndexChanged);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblAno.Location = new System.Drawing.Point(17, 12);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(168, 18);
            this.lblAno.TabIndex = 25;
            this.lblAno.Text = "Selecione o Ano:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblTurma.Location = new System.Drawing.Point(17, 50);
            this.lblTurma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(188, 18);
            this.lblTurma.TabIndex = 24;
            this.lblTurma.Text = "Selecione a Turma:";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInserir.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnInserir.Location = new System.Drawing.Point(255, 148);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(122, 23);
            this.btnInserir.TabIndex = 30;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // cbbProf
            // 
            this.cbbProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProf.FormattingEnabled = true;
            this.cbbProf.Location = new System.Drawing.Point(255, 123);
            this.cbbProf.Margin = new System.Windows.Forms.Padding(2);
            this.cbbProf.Name = "cbbProf";
            this.cbbProf.Size = new System.Drawing.Size(122, 21);
            this.cbbProf.TabIndex = 32;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblProf.Location = new System.Drawing.Point(17, 122);
            this.lblProf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(228, 18);
            this.lblProf.TabIndex = 31;
            this.lblProf.Text = "Selecione o Professor:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVoltar.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(15, 147);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(122, 23);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.cbbProf);
            this.panel1.Controls.Add(this.cbbAnos);
            this.panel1.Controls.Add(this.lblProf);
            this.panel1.Controls.Add(this.cbbTurma);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.lblDisciplina);
            this.panel1.Controls.Add(this.cbbDisciplina);
            this.panel1.Location = new System.Drawing.Point(32, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 187);
            this.panel1.TabIndex = 34;
            // 
            // DisciplinaProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(462, 240);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "DisciplinaProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplina Nova Prof";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDisciplina;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.ComboBox cbbTurma;
        private System.Windows.Forms.ComboBox cbbAnos;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ComboBox cbbProf;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel1;
    }
}