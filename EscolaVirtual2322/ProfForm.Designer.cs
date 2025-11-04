namespace EscolaVirtual2322
{
    partial class ProfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfForm));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblProf = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDados = new System.Windows.Forms.Button();
            this.tvTurmas = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblInserir = new System.Windows.Forms.Label();
            this.txtInserir = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTurmas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviar.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnEnviar.Location = new System.Drawing.Point(17, 329);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(248, 31);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar Mensagens";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Courier New", 17F);
            this.lblProf.Location = new System.Drawing.Point(12, 16);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(167, 32);
            this.lblProf.TabIndex = 6;
            this.lblProf.Text = "Bem vindo";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBack.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnBack.Location = new System.Drawing.Point(19, 402);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(245, 28);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDados
            // 
            this.btnDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDados.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnDados.Location = new System.Drawing.Point(19, 366);
            this.btnDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(245, 30);
            this.btnDados.TabIndex = 11;
            this.btnDados.Text = "Alterar Dados";
            this.btnDados.UseVisualStyleBackColor = false;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // tvTurmas
            // 
            this.tvTurmas.ImageIndex = 0;
            this.tvTurmas.ImageList = this.imageList1;
            this.tvTurmas.Location = new System.Drawing.Point(305, 50);
            this.tvTurmas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvTurmas.Name = "tvTurmas";
            this.tvTurmas.SelectedImageIndex = 0;
            this.tvTurmas.Size = new System.Drawing.Size(472, 379);
            this.tvTurmas.TabIndex = 13;
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
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblInserir.Location = new System.Drawing.Point(13, 76);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(139, 20);
            this.lblInserir.TabIndex = 14;
            this.lblInserir.Text = "Inserir Nota:";
            // 
            // txtInserir
            // 
            this.txtInserir.Location = new System.Drawing.Point(17, 100);
            this.txtInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInserir.Name = "txtInserir";
            this.txtInserir.Size = new System.Drawing.Size(247, 22);
            this.txtInserir.TabIndex = 15;
            this.txtInserir.TextChanged += new System.EventHandler(this.txtInserir_TextChanged);
            this.txtInserir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInserir_KeyPress);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInserir.Enabled = false;
            this.btnInserir.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnInserir.Location = new System.Drawing.Point(17, 127);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(248, 34);
            this.btnInserir.TabIndex = 16;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EscolaVirtual2322.Properties.Resources.update;
            this.pictureBox1.Location = new System.Drawing.Point(724, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTurmas
            // 
            this.lblTurmas.AutoSize = true;
            this.lblTurmas.Font = new System.Drawing.Font("Courier New", 17F);
            this.lblTurmas.Location = new System.Drawing.Point(299, 14);
            this.lblTurmas.Name = "lblTurmas";
            this.lblTurmas.Size = new System.Drawing.Size(133, 32);
            this.lblTurmas.TabIndex = 19;
            this.lblTurmas.Text = "Turmas:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tvTurmas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTurmas);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.lblProf);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtInserir);
            this.panel1.Controls.Add(this.btnDados);
            this.panel1.Controls.Add(this.lblInserir);
            this.panel1.Location = new System.Drawing.Point(37, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 455);
            this.panel1.TabIndex = 20;
            // 
            // ProfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(904, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ProfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel do Professor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.TreeView tvTurmas;
        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.TextBox txtInserir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTurmas;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
    }
}