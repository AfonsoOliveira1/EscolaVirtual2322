namespace EscolaVirtual2322
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tvEscola = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblEscola = new System.Windows.Forms.Label();
            this.grbAções = new System.Windows.Forms.GroupBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDadosProf = new System.Windows.Forms.Button();
            this.btnPedidosDados = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAddAlunos = new System.Windows.Forms.Button();
            this.btnAddProf = new System.Windows.Forms.Button();
            this.btnAddDisciplina = new System.Windows.Forms.Button();
            this.btnAddTurma = new System.Windows.Forms.Button();
            this.btnAddAno = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbAções.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvEscola
            // 
            this.tvEscola.BackColor = System.Drawing.SystemColors.Window;
            this.tvEscola.ImageIndex = 0;
            this.tvEscola.ImageList = this.imageList1;
            this.tvEscola.Location = new System.Drawing.Point(239, 52);
            this.tvEscola.Name = "tvEscola";
            this.tvEscola.SelectedImageIndex = 0;
            this.tvEscola.Size = new System.Drawing.Size(416, 337);
            this.tvEscola.TabIndex = 0;
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
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Font = new System.Drawing.Font("Courier New", 20F);
            this.lblEscola.Location = new System.Drawing.Point(14, 5);
            this.lblEscola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(109, 30);
            this.lblEscola.TabIndex = 5;
            this.lblEscola.Text = "Escola";
            // 
            // grbAções
            // 
            this.grbAções.Controls.Add(this.btnImportar);
            this.grbAções.Controls.Add(this.btnEditar);
            this.grbAções.Controls.Add(this.btnDadosProf);
            this.grbAções.Controls.Add(this.btnPedidosDados);
            this.grbAções.Controls.Add(this.btnRemover);
            this.grbAções.Controls.Add(this.btnAddAlunos);
            this.grbAções.Controls.Add(this.btnAddProf);
            this.grbAções.Controls.Add(this.btnAddDisciplina);
            this.grbAções.Controls.Add(this.btnAddTurma);
            this.grbAções.Controls.Add(this.btnAddAno);
            this.grbAções.Location = new System.Drawing.Point(19, 52);
            this.grbAções.Name = "grbAções";
            this.grbAções.Size = new System.Drawing.Size(212, 308);
            this.grbAções.TabIndex = 6;
            this.grbAções.TabStop = false;
            this.grbAções.Text = "Ações";
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnImportar.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnImportar.Location = new System.Drawing.Point(6, 279);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(196, 23);
            this.btnImportar.TabIndex = 9;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditar.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnEditar.Location = new System.Drawing.Point(6, 223);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(196, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDadosProf
            // 
            this.btnDadosProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDadosProf.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnDadosProf.Location = new System.Drawing.Point(6, 164);
            this.btnDadosProf.Name = "btnDadosProf";
            this.btnDadosProf.Size = new System.Drawing.Size(196, 23);
            this.btnDadosProf.TabIndex = 7;
            this.btnDadosProf.Text = "Pedidos de Professores";
            this.btnDadosProf.UseVisualStyleBackColor = false;
            this.btnDadosProf.Click += new System.EventHandler(this.btnDadosProf_Click);
            // 
            // btnPedidosDados
            // 
            this.btnPedidosDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPedidosDados.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnPedidosDados.Location = new System.Drawing.Point(6, 193);
            this.btnPedidosDados.Name = "btnPedidosDados";
            this.btnPedidosDados.Size = new System.Drawing.Size(196, 23);
            this.btnPedidosDados.TabIndex = 6;
            this.btnPedidosDados.Text = "Pedidos de Alunos";
            this.btnPedidosDados.UseVisualStyleBackColor = false;
            this.btnPedidosDados.Click += new System.EventHandler(this.btnPedidosDados_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemover.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnRemover.Location = new System.Drawing.Point(6, 250);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(196, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAddAlunos
            // 
            this.btnAddAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddAlunos.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnAddAlunos.Location = new System.Drawing.Point(6, 77);
            this.btnAddAlunos.Name = "btnAddAlunos";
            this.btnAddAlunos.Size = new System.Drawing.Size(196, 23);
            this.btnAddAlunos.TabIndex = 4;
            this.btnAddAlunos.Text = "Adicionar Aluno";
            this.btnAddAlunos.UseVisualStyleBackColor = false;
            this.btnAddAlunos.Click += new System.EventHandler(this.btnAddAlunos_Click);
            // 
            // btnAddProf
            // 
            this.btnAddProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddProf.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnAddProf.Location = new System.Drawing.Point(6, 135);
            this.btnAddProf.Name = "btnAddProf";
            this.btnAddProf.Size = new System.Drawing.Size(196, 23);
            this.btnAddProf.TabIndex = 3;
            this.btnAddProf.Text = "Adicionar Professor";
            this.btnAddProf.UseVisualStyleBackColor = false;
            this.btnAddProf.Click += new System.EventHandler(this.btnAddProf_Click);
            // 
            // btnAddDisciplina
            // 
            this.btnAddDisciplina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddDisciplina.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnAddDisciplina.Location = new System.Drawing.Point(6, 106);
            this.btnAddDisciplina.Name = "btnAddDisciplina";
            this.btnAddDisciplina.Size = new System.Drawing.Size(196, 23);
            this.btnAddDisciplina.TabIndex = 2;
            this.btnAddDisciplina.Text = "Adicionar Disciplina";
            this.btnAddDisciplina.UseVisualStyleBackColor = false;
            this.btnAddDisciplina.Click += new System.EventHandler(this.btnAddDisciplina_Click);
            // 
            // btnAddTurma
            // 
            this.btnAddTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddTurma.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnAddTurma.Location = new System.Drawing.Point(6, 48);
            this.btnAddTurma.Name = "btnAddTurma";
            this.btnAddTurma.Size = new System.Drawing.Size(196, 23);
            this.btnAddTurma.TabIndex = 1;
            this.btnAddTurma.Text = "Adicionar Turma";
            this.btnAddTurma.UseVisualStyleBackColor = false;
            this.btnAddTurma.Click += new System.EventHandler(this.btnAddTurma_Click);
            // 
            // btnAddAno
            // 
            this.btnAddAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddAno.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnAddAno.Location = new System.Drawing.Point(6, 19);
            this.btnAddAno.Name = "btnAddAno";
            this.btnAddAno.Size = new System.Drawing.Size(196, 23);
            this.btnAddAno.TabIndex = 0;
            this.btnAddAno.Text = "Adicionar Ano";
            this.btnAddAno.UseVisualStyleBackColor = false;
            this.btnAddAno.Click += new System.EventHandler(this.btnAddAno_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBack.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnBack.Location = new System.Drawing.Point(25, 366);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(196, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.grbAções);
            this.panel1.Controls.Add(this.tvEscola);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblEscola);
            this.panel1.Location = new System.Drawing.Point(57, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 407);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EscolaVirtual2322.Properties.Resources.update;
            this.pictureBox1.Location = new System.Drawing.Point(614, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(789, 442);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.grbAções.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvEscola;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.GroupBox grbAções;
        private System.Windows.Forms.Button btnAddProf;
        private System.Windows.Forms.Button btnAddDisciplina;
        private System.Windows.Forms.Button btnAddTurma;
        private System.Windows.Forms.Button btnAddAno;
        private System.Windows.Forms.Button btnAddAlunos;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnPedidosDados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDadosProf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnImportar;
    }
}