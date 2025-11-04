using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2322
{
    public partial class SaldoForm : Form
    {
        public double saldo;
        public SaldoForm()
        {
            InitializeComponent();
        }

        private void txtInserir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(txtInserir.Text != "")
            {
                saldo = Convert.ToDouble(txtInserir.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preenche a caixa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
