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
    public partial class DisciplinaProf : Form
    {
        public DisciplinaProf()
        {
            InitializeComponent();
            for (int i = 0; i < Listas.anos.Count; i++)
            {
                cbbAnos.Items.Add(Listas.anos[i].nome);
            }
            cbbAnos.SelectedIndex = 0;

            var allProf = Listas.anos
                .SelectMany(a => a.turmas)
                .SelectMany(t => t.listDisciplinas)
                .SelectMany(p => p.profs)
                .GroupBy(p => p.nif)
                .Select(g => g.First()) //tira os repetidos 20 minutos nisto.
                .ToList();

            cbbProf.DataSource = allProf; 
            cbbProf.DisplayMember = "nome";
        }
        public bool verificaExistente()
        {
            var profs = Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listDisciplinas[cbbDisciplina.SelectedIndex].profs;
            if (profs == null) return true;
            var profSelected = (Professores)cbbProf.SelectedItem;

            for (int i = 0; i < profs.Count; i++)
            {
                if (profs[i].nif == profSelected.nif)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(cbbProf.SelectedIndex != -1 && cbbAnos.SelectedIndex != -1 && cbbDisciplina.SelectedIndex != -1 && cbbTurma.SelectedIndex != -1)
            {
                if (verificaExistente())
                {
                    MessageBox.Show("O Professor já dá aula a essa disciplina!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var profSelected = (Professores)cbbProf.SelectedItem;
                    Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listDisciplinas[cbbDisciplina.SelectedIndex].profs.Add(profSelected);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos do Professor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void cbbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDisciplina.Items.Clear();
            for (int j = 0; j < Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listDisciplinas.Count; j++)
            {
                cbbDisciplina.Items.Add(Listas.anos[cbbAnos.SelectedIndex].turmas[cbbTurma.SelectedIndex].listDisciplinas[j].sigla);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["AdminForm"].Show();
            this.Close();
        }

    }
}
