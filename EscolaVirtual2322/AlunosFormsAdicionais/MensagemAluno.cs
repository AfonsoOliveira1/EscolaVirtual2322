using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2322.AlunosFormsAdicionais
{
    public partial class MensagemAluno : Form
    {
        string num;
        public MensagemAluno(string NUM)
        {
            InitializeComponent();
            num = NUM;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["AlunoForm"].Show();
            this.Close();
        }

        private void MensagemAluno_Load(object sender, EventArgs e)
        {
            var aluno = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(a => a.listAlunos)
                .FirstOrDefault(n => n.numAluno == num);

            for (int i = 0; i < aluno.mensagens.Count; i++)
            {
                lstMensagens.Items.Add(aluno.mensagens[i].ToString());
            }
        }

        private void lstMensagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstMensagens.SelectedItems.Count > 0)
            {
                btnVista.Enabled = true;
            }
            else
            {
                btnVista.Enabled = false;
            }
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            var aluno = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(a => a.listAlunos)
                .FirstOrDefault(n => n.numAluno == num);

            for (int i = 0; i < lstMensagens.SelectedItems.Count; i++)
            {
                var item = lstMensagens.SelectedItems[i];
                aluno.mensagens.Remove(item.ToString());
                lstMensagens.Items.Remove(item);
            }
        }
    }
}
