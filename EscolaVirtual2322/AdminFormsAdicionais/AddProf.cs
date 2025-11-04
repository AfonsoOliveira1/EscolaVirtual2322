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
    public partial class AddProf : Form
    {
        public AddProf()
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
            var idverifica = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(d => d.listDisciplinas)
                .SelectMany(p => p.profs)
                .Any(n => n.id == Convert.ToInt32(txtID.Text));

            if (idverifica) return true;
            return false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() != "" && txtID.Text.Trim() != "" && txtLogin.Text.Trim() != "" && txtPass.Text.Trim() != "" &&
                cbbAnos.SelectedIndex != -1 && cbbTurma.SelectedIndex != -1 && cbbDisciplina.SelectedIndex != -1)
            {
                if (verificaExistente())
                {
                    MessageBox.Show("Professor já Existe", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listDisciplinas[cbbDisciplina.SelectedIndex].profs.Add(
                        new Professores(Convert.ToInt32(txtID.Text.Trim()), Convert.ToInt32(txtNIF.Text.Trim()), txtNome.Text, txtLogin.Text.Trim(), txtPass.Text.Trim()));
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos do Professor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbbAnos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbbTurma.Items.Clear();
            for (int j = 0; j < Listas.anos[cbbAnos.SelectedIndex].turmas.Count; j++)
            {
                cbbTurma.Items.Add(Listas.anos[cbbAnos.SelectedIndex].turmas[j].sigla);
            }
            cbbTurma.SelectedIndex = 0;
        }

        private void cbbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDisciplina.Items.Clear();
            for(int j = 0; j < Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listDisciplinas.Count; j++)
            {
                cbbDisciplina.Items.Add(Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listDisciplinas[j].sigla);
            }
        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnColocar_Click(object sender, EventArgs e)
        {
            DisciplinaProf form = new DisciplinaProf();
            form.Show();
            this.Close();
        }
    }
}
