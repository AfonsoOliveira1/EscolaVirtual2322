using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2322
{
    public partial class AlterarDadosProf : Form
    {
        int id;
        public AlterarDadosProf(int ID)
        {
            InitializeComponent();
            id = ID;
            var prof = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(d => d.listDisciplinas)
                .SelectMany(p => p.profs)
                .FirstOrDefault(n => n.id == id);
            txtNome.Text = prof.nome;
            txtLogin.Text = prof.log;
            txtPassword.Text = prof.pass;
            txtNIF.Text = $"{prof.nif}";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["ProfForm"].Show();
            this.Close();
        }

        private void btnPedirDados_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtNIF.Text.Trim() != "" && txtNome.Text.Trim() != "")
            {
                var prof = Listas.anos
                    .SelectMany(t => t.turmas)
                    .SelectMany(d => d.listDisciplinas)
                    .SelectMany(p => p.profs)
                    .FirstOrDefault(n => n.id == id);

                var check = Listas.anos
                    .SelectMany(t => t.turmas)
                    .SelectMany(d => d.listDisciplinas)
                    .SelectMany(p => p.profs)
                    .FirstOrDefault(l => l.log == txtLogin.Text.Trim());

                var checkA = Listas.anos
                    .SelectMany(t => t.turmas)
                    .SelectMany(a => a.listAlunos)
                    .FirstOrDefault(l => l.log == txtLogin.Text.Trim());

                if ((check == null && checkA == null) || prof.log == txtLogin.Text.Trim())
                {
                    string nome = txtNome.Text.Trim();
                    string login = txtLogin.Text.Trim();
                    string password = txtPassword.Text.Trim();
                    int nif = Convert.ToInt32(txtNIF.Text.Trim());
                    Listas.dadosP.Add(new Professores(id, nif, nome, login, password));
                    MessageBox.Show("Pedido de Alteração foi Enviada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Esse login já esta em uso", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preenche todas as caixas de texto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
