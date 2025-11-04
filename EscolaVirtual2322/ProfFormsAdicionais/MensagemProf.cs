using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2322.ProfFormsAdicionais
{
    public partial class MensagemProf : Form
    {
        int nif;
        public MensagemProf(int NIF)
        {
            InitializeComponent();
            for (int i = 0; i < Listas.anos.Count; i++)
            {
                cbbAnos.Items.Add(Listas.anos[i].nome);
            }
            cbbAnos.SelectedIndex = 0;
            nif = NIF;
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text == "" || cbbAnos.SelectedIndex == -1 || cbbTurma.SelectedIndex == -1 || cbbAlunosEnvio.SelectedIndex == -1)
            {
                MessageBox.Show("Insira todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mensagem = txtMensagem.Text;
                var prof = Listas.anos
                    .SelectMany(t => t.turmas)
                    .SelectMany(d => d.listDisciplinas)
                    .SelectMany(p => p.profs)
                    .FirstOrDefault(n => n.nif == nif);

                Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listAlunos[cbbAlunosEnvio.SelectedIndex].mensagens.Add($"{prof.nome}: {mensagem}");
                txtMensagem.Clear();

                MessageBox.Show("Mensagem enviada com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["ProfForm"].Show();
            this.Close();
        }

        private void cbbAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTurma.Items.Clear();
            for (int j = 0; j < Listas.anos[cbbAnos.SelectedIndex].turmas.Count; j++)
            {
                cbbTurma.Items.Add(Listas.anos[cbbAnos.SelectedIndex].turmas[j].sigla);
            }
        }

        private void cbbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbAlunosEnvio.Items.Clear();
            for (int j = 0; j < Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listAlunos.Count; j++)
            {
                cbbAlunosEnvio.Items.Add(Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listAlunos[j].nome);
            }
        }
    }
}
