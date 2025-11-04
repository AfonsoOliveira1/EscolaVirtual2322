using EscolaVirtual2322.AlunosFormsAdicionais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace EscolaVirtual2322
{
    public partial class AlunoForm : Form
    {
        public string num;
        bool sair = true;
        public AlunoForm(string NUM)
        {
            InitializeComponent();
            num = NUM;
            var aluno = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(a => a.listAlunos)
                .Where(n => n.numAluno == num)
                .First();
            lblNome.Text = $"Bem vindo, {aluno.nome}!";
            lblSaldo.Text = $"Saldo: {aluno.saldo:C2}";
            lblNotificações.Text = $"Notificações: {aluno.mensagens.Count}";
            if(aluno.mensagens.Count > 0)
            {
                lblNotificações.ForeColor = Color.Red;
            }
            else
            {
                lblNotificações.ForeColor = Color.Black;
            }
            PopularTree();
        }

        public void PopularTree()
        {
            tvNotas.Nodes.Clear();
            var aluno = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(a => a.listAlunos)
                .FirstOrDefault(n => n.numAluno == num);

            var turma = Listas.anos
                .SelectMany(t => t.turmas)
                .FirstOrDefault(a => a.listAlunos.Any(n => n.numAluno == num));

            var ano = Listas.anos
                .FirstOrDefault(t => t.turmas.Any(a => a.listAlunos.Any(n => n.numAluno == num)));

            TreeNode anoNode = new TreeNode();
            anoNode.Text = ano.nome;
            anoNode.ImageIndex = 0;

            TreeNode turmaNode = new TreeNode();
            turmaNode.Text = turma.sigla;
            turmaNode.ImageIndex = turmaNode.SelectedImageIndex = 2;

            anoNode.Nodes.Add(turmaNode);

            TreeNode alunoNode = new TreeNode();
            alunoNode.Text = aluno.nome;
            alunoNode.ImageIndex = alunoNode.SelectedImageIndex = 3;

            turmaNode.Nodes.Add(alunoNode);

            for(int i = 0; i < turma.listDisciplinas.Count; i++)
            {
                TreeNode disc = new TreeNode();
                disc.Text = turma.listDisciplinas[i].sigla;
                disc.ImageIndex = disc.SelectedImageIndex = 4;
                for (int j = 0; j < aluno.notas.Count; j++)
                {
                    if (aluno.notas[j].disc == disc.Text)
                    {
                        TreeNode nota = new TreeNode();
                        nota.Text = Convert.ToString(aluno.notas[j].classi);
                        nota.ImageIndex = nota.SelectedImageIndex = 5;
                        disc.Nodes.Add(nota);
                    }
                }
                alunoNode.Nodes.Add(disc);
            }
            tvNotas.Nodes.Add(anoNode);
            tvNotas.ExpandAll();

            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminho = Path.Combine(pastaDocumentos, "Dados", "alunos.json");
            if (File.Exists(caminho))
            {
                var dados = new
                {
                    Ano = ano,
                    Turma = turma,
                    Aluno = aluno
                };
                string jsonAluno = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminho, jsonAluno);
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            var aluno = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(a => a.listAlunos)
                .Where(n => n.numAluno == num)
                .First();

            SaldoForm form = new SaldoForm();
            form.ShowDialog();
            aluno.saldo += form.saldo;
            lblSaldo.Text = $"Saldo: {aluno.saldo:C2}";
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            AlterarDadosAluno form = new AlterarDadosAluno(num);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            sair = false;
            Application.OpenForms["Login"].Show();
            this.Close();
        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            var aluno = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(a => a.listAlunos)
                .FirstOrDefault(n => n.numAluno == num);
            MensagemAluno form = new MensagemAluno(num);
            form.ShowDialog();
            lblNotificações.Text = $"Notificações: {aluno.mensagens.Count}";
            if (aluno.mensagens.Count > 0)
            {
                lblNotificações.ForeColor = Color.Red;
            }
            else
            {
                lblNotificações.ForeColor = Color.Black;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PopularTree();
        }

        private void AlunoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sair == true)
            {
                Application.Exit();
            }
        }
    }
}
