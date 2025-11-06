using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2322
{
    public partial class AlterarDadosAluno : Form
    {
        public string num;
        public AlterarDadosAluno(string numAluno)
        {
            InitializeComponent();
            num = numAluno;
            var aluno = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(a => a.listAlunos)
                .FirstOrDefault(n => n.numAluno == num);
            txtNIF.Text = $"{aluno.nif}";
            txtLogin.Text = aluno.log;
            txtNome.Text = aluno.nome;
            txtPassword.Text = aluno.pass;
        }

        private void btnPedirDados_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtNIF.Text.Trim() != "" && txtNome.Text.Trim() != "") 
            {
                var check = Listas.anos
                    .SelectMany(t => t.turmas)
                    .SelectMany(a => a.listAlunos)
                    .FirstOrDefault(l => l.log == txtLogin.Text.Trim());

                var checkP = Listas.anos
                    .SelectMany(t => t.turmas)
                    .SelectMany(d => d.listDisciplinas)
                    .SelectMany(p => p.profs)
                    .FirstOrDefault(l => l.log == txtLogin.Text.Trim());

                var aluno = Listas.anos
                    .SelectMany(t => t.turmas)
                    .SelectMany(a => a.listAlunos)
                    .FirstOrDefault(n => n.numAluno == num);

                if ((check == null && checkP == null) || aluno.log == txtLogin.Text.Trim())
                {
                    string nome = txtNome.Text.Trim();
                    string login = txtLogin.Text.Trim();
                    string password = txtPassword.Text.Trim();
                    int nif = Convert.ToInt32(txtNIF.Text.Trim());
                    Listas.dadosA.Add(new Alunos(num, nif, nome, login, password));
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
                MessageBox.Show("Preenche todas as caixas de texto!","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["AlunoForm"].Show();
            this.Close();
        }
    }
}
