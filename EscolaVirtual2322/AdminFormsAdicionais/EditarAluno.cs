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
    public partial class EditarAluno : Form
    {
        int id;
        string nome, num;
        public EditarAluno(int ID, string name, string NUM)
        {
            InitializeComponent();
            id = ID;
            nome = name;
            num = NUM;
            txtNum.Text = NUM;
            var aluno = Listas.anos[id].turmas.FirstOrDefault(n => n.nome == nome).listAlunos.FirstOrDefault(m => m.numAluno == NUM);
            txtLogin.Text = aluno.log;
            txtNIF.Text = Convert.ToString(aluno.nif);
            txtPass.Text = aluno.pass;
        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() != "" && txtLogin.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                var checkAluno = Listas.anos.SelectMany(a => a.turmas).SelectMany(t => t.listAlunos).FirstOrDefault(l => l.log == txtLogin.Text);
                var prof = Listas.anos.SelectMany(a => a.turmas).SelectMany(d => d.listDisciplinas).SelectMany(p => p.profs).FirstOrDefault(l => l.log == txtLogin.Text);
                var aluno = Listas.anos[id].turmas.SelectMany(a => a.listAlunos).FirstOrDefault(l => l.numAluno == num);
                if ((checkAluno == null && prof == null) || aluno.log == txtLogin.Text)
                {
                    aluno.nome = txtNome.Text;
                    aluno.log = txtLogin.Text;
                    aluno.pass = txtPass.Text;
                    aluno.nif = Convert.ToInt32(txtNIF.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Digite um nome ou login não existente ao Aluno!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Digite um nome valido para o Aluno!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
