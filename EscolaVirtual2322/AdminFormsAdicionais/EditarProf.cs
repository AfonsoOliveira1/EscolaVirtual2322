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
    public partial class EditarProf : Form
    {
        int nif;
        public EditarProf(int NIF)
        {
            InitializeComponent();
            nif = NIF;
            txtNIF.Text = Convert.ToString(nif);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() != "" && txtLogin.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                var check = Listas.anos
                    .SelectMany(a => a.turmas)
                    .SelectMany(d => d.listDisciplinas)
                    .SelectMany(p => p.profs)
                    .FirstOrDefault(l => l.log == txtLogin.Text);
                if (check != null)
                {
                    MessageBox.Show("Digite um login não existente o Professor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var prof = Listas.anos.SelectMany(a => a.turmas).SelectMany(d => d.listDisciplinas).SelectMany(p => p.profs).FirstOrDefault(l => l.nif == nif);
                    prof.nome = txtNome.Text;
                    prof.log = txtLogin.Text;
                    prof.pass = txtPass.Text;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite um nome valido para o Professor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
