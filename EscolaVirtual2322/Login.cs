using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscolaVirtual2322.Dados;

namespace EscolaVirtual2322
{
    public partial class Login : Form
    {
        public Admin admin = new Admin();
        public Login()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {
                btnLog.Enabled = true;
            }
            else
            {
                btnLog.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {
                btnLog.Enabled = true;
            }
            else
            {
                btnLog.Enabled = false;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            UsersJSON usersJSON = new UsersJSON();
            Utilizadores user = usersJSON.ObterUtilizador(login, password);

            if (usersJSON.Login(login, password))
            {
                if (user.cargo == Cargos.Admin)
                {
                    this.Hide();
                    new AdminForm().Show();
                }

                if (user is Alunos aluno)
                {
                    this.Hide();
                    new AlunoForm(aluno.numAluno).Show();
                }

                if (user is Professores prof)
                {
                    this.Hide();
                    new ProfForm(prof.id).Show();
                }
            }
            else
            {
                MessageBox.Show("Login ou password inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
    }
}
