using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2322.AdminFormsAdicionais
{
    public partial class EditarProf : Form
    {
        int id;
        public EditarProf(int ID)
        {
            InitializeComponent();
            id = ID;
            var prof = Listas.anos
                .SelectMany(a => a.turmas)
                .SelectMany(d => d.listDisciplinas)
                .SelectMany(p => p.profs)
                .FirstOrDefault(l => l.id == id);
            txtID.Text = Convert.ToString(id);
            txtNome.Text = prof.nome;
            txtLogin.Text = prof.log;
            txtPass.Text = prof.pass;
            txtNIF.Text = Convert.ToString(prof.nif);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() != "" && txtLogin.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                var prof = Listas.anos
                    .SelectMany(a => a.turmas)
                    .SelectMany(d => d.listDisciplinas)
                    .SelectMany(p => p.profs)
                    .FirstOrDefault(l => l.id == id);
                var check = Listas.anos
                    .SelectMany(a => a.turmas)
                    .SelectMany(d => d.listDisciplinas)
                    .SelectMany(p => p.profs)
                    .FirstOrDefault(l => l.log == txtLogin.Text);

                var checkAluno = Listas.anos.SelectMany(a => a.turmas).SelectMany(t => t.listAlunos).FirstOrDefault(l => l.log == txtLogin.Text);

                if ((check == null && checkAluno == null) || prof.log == txtLogin.Text.Trim())
                {
                    prof.nome = txtNome.Text;
                    prof.log = txtLogin.Text;
                    prof.pass = txtPass.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Digite um login não existente o Professor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Digite um nome valido para o Professor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
