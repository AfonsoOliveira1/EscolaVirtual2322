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
    public partial class AddTurma : Form
    {
        public AddTurma()
        {
            InitializeComponent();
            for(int i = 0; i < Listas.anos.Count; i++)
            {
                cbbAnos.Items.Add(Listas.anos[i].nome);
            }
            cbbAnos.SelectedIndex = 0;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(txtTurma.Text.Trim() != "" && txtSigla.Text.Trim() != "" && cbbAnos.SelectedIndex != -1)
            {
                if (Listas.anos.SelectMany(a => a.turmas).Any(s => s.sigla == txtSigla.Text))
                {
                    MessageBox.Show("Sigla da Turma tem de ser diferente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Listas.anos[cbbAnos.SelectedIndex].turmas.Add(new Turmas(txtSigla.Text.Trim(), txtTurma.Text.Trim()));
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite um nome valido ou Preencha todos os campos para a Turma!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
