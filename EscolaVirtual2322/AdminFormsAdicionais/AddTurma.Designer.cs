namespace EscolaVirtual2322.AdminFormsAdicionais
{
    partial class AddTurma
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
            this.lblTurma = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblAno = new System.Windows.Forms.Label();
            this.cbbAnos = new System.Windows.Forms.ComboBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblTurma.Location = new System.Drawing.Point(19, 13);
            this.lblTurma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(198, 18);
            this.lblTurma.TabIndex = 4;
            this.lblTurma.Text = "Nome da Turma nova:";
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(221, 13);
            this.txtTurma.Margin = new System.Windows.Forms.Padding(2);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(122, 20);
            this.txtTurma.TabIndex = 5;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInserir.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnInserir.Location = new System.Drawing.Point(221, 122);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(122, 23);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblAno.Location = new System.Drawing.Point(19, 85);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(168, 18);
            this.lblAno.TabIndex = 7;
            this.lblAno.Text = "Selecione o Ano:";
            // 
            // cbbAnos
            // 
            this.cbbAnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnos.FormattingEnabled = true;
            this.cbbAnos.Location = new System.Drawing.Point(221, 81);
            this.cbbAnos.Margin = new System.Windows.Forms.Padding(2);
            this.cbbAnos.Name = "cbbAnos";
            this.cbbAnos.Size = new System.Drawing.Size(122, 21);
            this.cbbAnos.TabIndex = 8;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblSigla.Location = new System.Drawing.Point(19, 49);
            this.lblSigla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(158, 18);
            this.lblSigla.TabIndex = 9;
            this.lblSigla.Text = "Sigla da Turma:";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(221, 48);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(2);
            this.txtSigla.MaxLength = 8;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(122, 20);
            this.txtSigla.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.txtSigla);
            this.panel1.Controls.Add(this.txtTurma);
            this.panel1.Controls.Add(this.lblSigla);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.cbbAnos);
            this.panel1.Controls.Add(this.lblAno);
            this.panel1.Location = new System.Drawing.Point(36, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 172);
            this.panel1.TabIndex = 11;
            // 
            // AddTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(425, 228);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Turma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cbbAnos;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Panel panel1;
    }
}