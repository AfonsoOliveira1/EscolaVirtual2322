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
    public partial class AddDisciplina : Form
    {
        public AddDisciplina()
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
            var disc = Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listDisciplinas;
            for (int i = 0;i < disc.Count; i++)
            {
                if (disc[i].nome == txtNome.Text && disc[i].sigla == txtSigla.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtSigla.Text.Trim() != "" && txtNome.Text.Trim() != "" && cbbAnos.SelectedIndex != -1 && cbbTurma.SelectedIndex != -1)
            {
                if (verificaExistente() == false)
                {
                    Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listDisciplinas.Add(
                        new Disciplina(txtSigla.Text.ToUpper(), txtNome.Text));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ja existe essa disciplina!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos da Disciplina!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
