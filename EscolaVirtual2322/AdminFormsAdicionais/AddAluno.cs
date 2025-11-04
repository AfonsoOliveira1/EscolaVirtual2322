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
    public partial class AddAluno : Form
    {
        public AddAluno()
        {
            InitializeComponent();
            for (int i = 0; i < Listas.anos.Count; i++)
            {
                cbbAnos.Items.Add(Listas.anos[i].nome);
            }
            cbbAnos.SelectedIndex = 0;
        }
        public bool verificaExistente()
        {
            var nifverifica = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(d => d.listAlunos)
                .Any(n => n.numAluno == $"I{txtNum.Text}");

            if (nifverifica) return true;

            return false;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() != "" && txtNum.Text.Trim() != "" && txtLogin.Text.Trim() != "" && txtPass.Text.Trim() != "" && cbbAnos.SelectedIndex != -1 && cbbTurma.SelectedIndex != -1)
            {
                if (verificaExistente())
                {
                    MessageBox.Show("Aluno já Existe!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listAlunos.Add(
                        new Alunos($"I{txtNum.Text.Trim()}", Convert.ToInt32(txtNIF.Text),txtNome.Text, txtLogin.Text.Trim(), txtPass.Text.Trim()));
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos do Aluno!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbbAnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTurma.Items.Clear();
            for (int j = 0; j < Listas.anos[cbbAnos.SelectedIndex].turmas.Count; j++)
            {
                cbbTurma.Items.Add(Listas.anos[cbbAnos.SelectedIndex].turmas[j].sigla);
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
