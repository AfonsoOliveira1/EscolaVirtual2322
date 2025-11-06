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
    public partial class EditarDisc : Form
    {
        int id;
        string nome, sigla;
        public EditarDisc(int ID, string name, string SIGLA)
        {
            InitializeComponent();
            id = ID;
            nome = name;
            sigla = SIGLA;
            var disc = Listas.anos[id].turmas.FirstOrDefault(n => n.nome == nome).listDisciplinas.FirstOrDefault(m => m.sigla == SIGLA);
            txtNome.Text = disc.nome;
            txtSigla.Text = disc.sigla;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() != "" && txtSigla.Text.Trim() != "")
            {
                var turma = Listas.anos[id].turmas.FirstOrDefault(n => n.nome == nome);
                if (turma.listDisciplinas.Any(n => n.nome == txtNome.Text) || turma.listDisciplinas.Any(s => s.sigla == txtSigla.Text))
                {
                    MessageBox.Show("Digite um nome e sigla não existente para a Disciplina!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var disc = turma.listDisciplinas.FirstOrDefault(i => i.sigla == sigla);
                    disc.nome = txtNome.Text;
                    disc.sigla = txtSigla.Text;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite um nome valido para a Disciplina!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
