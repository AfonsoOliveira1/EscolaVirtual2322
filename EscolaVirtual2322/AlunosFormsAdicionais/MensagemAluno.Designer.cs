namespace EscolaVirtual2322.AlunosFormsAdicionais
{
    partial class MensagemAluno
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
            this.lstMensagens = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMensagens
            // 
            this.lstMensagens.FormattingEnabled = true;
            this.lstMensagens.Location = new System.Drawing.Point(28, 57);
            this.lstMensagens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMensagens.Name = "lstMensagens";
            this.lstMensagens.Size = new System.Drawing.Size(312, 225);
            this.lstMensagens.TabIndex = 6;
            this.lstMensagens.SelectedIndexChanged += new System.EventHandler(this.lstMensagens_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVoltar.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(29, 286);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(148, 30);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F);
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensagens";
            // 
            // btnVista
            // 
            this.btnVista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVista.Enabled = false;
            this.btnVista.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnVista.Location = new System.Drawing.Point(180, 286);
            this.btnVista.Margin = new System.Windows.Forms.Padding(2);
            this.btnVista.Name = "btnVista";
            this.btnVista.Size = new System.Drawing.Size(160, 30);
            this.btnVista.TabIndex = 7;
            this.btnVista.Text = "Vista";
            this.btnVista.UseVisualStyleBackColor = false;
            this.btnVista.Click += new System.EventHandler(this.btnVista_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnVista);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstMensagens);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(20, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 331);
            this.panel1.TabIndex = 8;
            // 
            // MensagemAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(425, 376);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MensagemAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagens";
            this.Load += new System.EventHandler(this.MensagemAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMensagens;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVista;
        private System.Windows.Forms.Panel panel1;
    }
}