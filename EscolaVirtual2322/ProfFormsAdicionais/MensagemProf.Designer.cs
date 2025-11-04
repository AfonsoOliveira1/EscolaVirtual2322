namespace EscolaVirtual2322.ProfFormsAdicionais
{
    partial class MensagemProf
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.cbbAlunosEnvio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.cbbAnos = new System.Windows.Forms.ComboBox();
            this.cbbTurma = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVoltar.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(29, 386);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(221, 28);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviarMensagem.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnEnviarMensagem.Location = new System.Drawing.Point(268, 386);
            this.btnEnviarMensagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(239, 28);
            this.btnEnviarMensagem.TabIndex = 20;
            this.btnEnviarMensagem.Text = "Enviar mensagens";
            this.btnEnviarMensagem.UseVisualStyleBackColor = false;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Courier New", 15F);
            this.lblMensagem.Location = new System.Drawing.Point(28, 17);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(253, 29);
            this.lblMensagem.TabIndex = 19;
            this.lblMensagem.Text = "Enviar Mensagens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F);
            this.label2.Location = new System.Drawing.Point(327, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(268, 113);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(239, 266);
            this.txtMensagem.TabIndex = 17;
            // 
            // cbbAlunosEnvio
            // 
            this.cbbAlunosEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlunosEnvio.FormattingEnabled = true;
            this.cbbAlunosEnvio.Items.AddRange(new object[] {
            "Miguel",
            "Afonso"});
            this.cbbAlunosEnvio.Location = new System.Drawing.Point(34, 261);
            this.cbbAlunosEnvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAlunosEnvio.Name = "cbbAlunosEnvio";
            this.cbbAlunosEnvio.Size = new System.Drawing.Size(217, 24);
            this.cbbAlunosEnvio.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F);
            this.label1.Location = new System.Drawing.Point(29, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selecionar Aluno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Controls.Add(this.cbbAnos);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.cbbTurma);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEnviarMensagem);
            this.panel1.Controls.Add(this.cbbAlunosEnvio);
            this.panel1.Controls.Add(this.txtMensagem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(43, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 452);
            this.panel1.TabIndex = 22;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblTurma.Location = new System.Drawing.Point(29, 172);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(214, 22);
            this.lblTurma.TabIndex = 23;
            this.lblTurma.Text = "Selecione a Turma";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblAno.Location = new System.Drawing.Point(30, 112);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(238, 28);
            this.lblAno.TabIndex = 24;
            this.lblAno.Text = "Selecione o Ano";
            // 
            // cbbAnos
            // 
            this.cbbAnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnos.FormattingEnabled = true;
            this.cbbAnos.Location = new System.Drawing.Point(33, 136);
            this.cbbAnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAnos.Name = "cbbAnos";
            this.cbbAnos.Size = new System.Drawing.Size(218, 24);
            this.cbbAnos.TabIndex = 25;
            this.cbbAnos.SelectedIndexChanged += new System.EventHandler(this.cbbAnos_SelectedIndexChanged);
            // 
            // cbbTurma
            // 
            this.cbbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTurma.FormattingEnabled = true;
            this.cbbTurma.Location = new System.Drawing.Point(34, 196);
            this.cbbTurma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTurma.Name = "cbbTurma";
            this.cbbTurma.Size = new System.Drawing.Size(217, 24);
            this.cbbTurma.TabIndex = 26;
            this.cbbTurma.SelectedIndexChanged += new System.EventHandler(this.cbbTurma_SelectedIndexChanged);
            // 
            // MensagemProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(655, 558);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MensagemProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MensagemProf";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEnviarMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.ComboBox cbbAlunosEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cbbAnos;
        private System.Windows.Forms.ComboBox cbbTurma;
    }
}