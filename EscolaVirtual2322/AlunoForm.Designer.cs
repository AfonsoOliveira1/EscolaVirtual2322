namespace EscolaVirtual2322
{
    partial class AlunoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlunoForm));
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tvNotas = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.lblNotificações = new System.Windows.Forms.Label();
            this.btnDados = new System.Windows.Forms.Button();
            this.btnMensagens = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblSaldo.Location = new System.Drawing.Point(19, 117);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(106, 22);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo: 0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Courier New", 15F);
            this.lblNome.Location = new System.Drawing.Point(19, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(163, 29);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Bem vindo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15F);
            this.label3.Location = new System.Drawing.Point(347, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notas";
            // 
            // tvNotas
            // 
            this.tvNotas.ImageIndex = 0;
            this.tvNotas.ImageList = this.imageList1;
            this.tvNotas.Location = new System.Drawing.Point(352, 50);
            this.tvNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvNotas.Name = "tvNotas";
            this.tvNotas.SelectedImageIndex = 0;
            this.tvNotas.Size = new System.Drawing.Size(415, 405);
            this.tvNotas.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "inete.ico");
            this.imageList1.Images.SetKeyName(1, "professor.ico");
            this.imageList1.Images.SetKeyName(2, "turma.ico");
            this.imageList1.Images.SetKeyName(3, "aluno.ico");
            this.imageList1.Images.SetKeyName(4, "disciplina.ico");
            this.imageList1.Images.SetKeyName(5, "grade.ico");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBack.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnBack.Location = new System.Drawing.Point(21, 428);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(207, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblNotificações
            // 
            this.lblNotificações.AutoSize = true;
            this.lblNotificações.BackColor = System.Drawing.SystemColors.Control;
            this.lblNotificações.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblNotificações.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNotificações.Location = new System.Drawing.Point(19, 245);
            this.lblNotificações.Name = "lblNotificações";
            this.lblNotificações.Size = new System.Drawing.Size(190, 22);
            this.lblNotificações.TabIndex = 9;
            this.lblNotificações.Text = "Notificações: 0";
            // 
            // btnDados
            // 
            this.btnDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDados.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnDados.Location = new System.Drawing.Point(23, 393);
            this.btnDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(207, 28);
            this.btnDados.TabIndex = 10;
            this.btnDados.Text = "Alterar Dados";
            this.btnDados.UseVisualStyleBackColor = false;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // btnMensagens
            // 
            this.btnMensagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMensagens.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnMensagens.Location = new System.Drawing.Point(21, 276);
            this.btnMensagens.Margin = new System.Windows.Forms.Padding(4);
            this.btnMensagens.Name = "btnMensagens";
            this.btnMensagens.Size = new System.Drawing.Size(207, 28);
            this.btnMensagens.TabIndex = 11;
            this.btnMensagens.Text = "Ver Mensagens";
            this.btnMensagens.UseVisualStyleBackColor = false;
            this.btnMensagens.Click += new System.EventHandler(this.btnMensagens_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDepositar.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnDepositar.Location = new System.Drawing.Point(21, 146);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(207, 28);
            this.btnDepositar.TabIndex = 12;
            this.btnDepositar.Text = "Depositar Saldo";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.btnDados);
            this.panel1.Controls.Add(this.btnDepositar);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.tvNotas);
            this.panel1.Controls.Add(this.btnMensagens);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNotificações);
            this.panel1.Location = new System.Drawing.Point(63, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 475);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EscolaVirtual2322.Properties.Resources.update;
            this.pictureBox1.Location = new System.Drawing.Point(713, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(925, 548);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AlunoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel do Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlunoForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView tvNotas;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblNotificações;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Button btnMensagens;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}