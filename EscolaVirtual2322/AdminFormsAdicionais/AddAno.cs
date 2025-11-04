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
    public partial class AddAno : Form
    {
        public AddAno()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(txtInserir.Text.Trim() != "")
            {
                if(Listas.anos.Any(n => n.nome == txtInserir.Text))
                {
                    MessageBox.Show("Digite um nome não existente para o Ano!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Listas.anos.Add(new Ano(Listas.anos.Count + 1, txtInserir.Text.Trim()));
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite um nome valido para o Ano!","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
