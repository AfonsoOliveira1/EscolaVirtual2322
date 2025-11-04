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
    public partial class EditarTurma : Form
    {
        string nome;
        int id;
        public EditarTurma(int ID, string name)
        {
            InitializeComponent();
            id = ID;
            nome = name;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtInserir.Text.Trim() != "" && txtSigla.Text.Trim() != "")
            {
                if (Listas.anos[id].turmas.Any(n => n.sigla == txtSigla.Text))
                {
                    MessageBox.Show("Digite uma sigla não existente para a Turma!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var ano = Listas.anos.FirstOrDefault(i => i.id == id);
                    var turma = ano.turmas.FirstOrDefault(n => n.nome == nome);
                    turma.nome = txtInserir.Text;
                    turma.sigla = txtSigla.Text;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite um nome valido para a Turma!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
