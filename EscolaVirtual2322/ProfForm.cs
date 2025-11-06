using EscolaVirtual2322.Classes;
using EscolaVirtual2322.ProfFormsAdicionais;
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
    public partial class ProfForm : Form
    {
        int id;
        bool sair = true;
        public ProfForm(int ID)
        {
            InitializeComponent();
            id = ID;
            var prof = Listas.anos
                .SelectMany(t => t.turmas)
                .SelectMany(d => d.listDisciplinas)
                .SelectMany(p => p.profs)
                .FirstOrDefault(n => n.id == id);
            lblProf.Text = $"Bem vindo, {prof.nome}!";
            PopularTree();
        }

        public void PopularTree()
        {
            tvTurmas.Nodes.Clear();

            var anosProf = Listas.anos
                .Where(ano => ano.turmas
                .Any(turma => turma.listDisciplinas
                .Any(disc => disc.profs.Any(p => p.id == id))))
                .ToList();

            foreach (var ano in anosProf)
            {
                TreeNode anoNode = new TreeNode(ano.nome) { ImageIndex = 0 };

                
                var turmasProf = ano.turmas
                    .Where(turma => turma.listDisciplinas
                    .Any(disc => disc.profs.Any(p => p.id == id)))
                    .ToList();

                foreach (var turma in turmasProf)
                {
                    TreeNode turmaNode = new TreeNode(turma.sigla)
                    {
                        ImageIndex = 2,
                        SelectedImageIndex = 2
                    };

                    var discProfs = turma.listDisciplinas
                        .Where(disc => disc.profs.Any(p => p.id == id))
                        .ToList();

                    foreach (var disc in discProfs)
                    {
                        TreeNode discNode = new TreeNode(disc.sigla)
                        {
                            ImageIndex = 4,
                            SelectedImageIndex = 4
                        };

                        foreach (var aluno in turma.listAlunos)
                        {
                            TreeNode alunoNode = new TreeNode()
                            {
                                ImageIndex = 3,
                                SelectedImageIndex = 3
                            };
                            var nota = aluno.notas.FirstOrDefault(n => n.disc == disc.sigla);
                            string texto = $"{aluno.nome}: ";
                            if (nota != null)
                            {
                                alunoNode.Text = $"{texto}{nota.classi}";
                            }
                            else
                            {
                                alunoNode.Text = $"{texto}Sem Nota";
                            }
                            discNode.Nodes.Add(alunoNode);
                        }

                        turmaNode.Nodes.Add(discNode);
                    }

                    anoNode.Nodes.Add(turmaNode);
                }

                tvTurmas.Nodes.Add(anoNode);
            }

            tvTurmas.ExpandAll();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            AlterarDadosProf form = new AlterarDadosProf(id);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            sair = false;
            Application.OpenForms["Login"].Show();
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MensagemProf form = new MensagemProf(id);
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PopularTree();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tvTurmas.SelectedNode;
            if(selectedNode != null)
            {
                switch (selectedNode.Level)
                {
                    case 3:
                        TreeNode discNode = selectedNode.Parent;
                        TreeNode turmaNode = discNode.Parent;
                        TreeNode anoNode = turmaNode.Parent;

                        var ano = Listas.anos.FirstOrDefault(a => a.nome == anoNode.Text);
                        var turma = ano.turmas.FirstOrDefault(t => t.sigla == turmaNode.Text);
                        var disciplina = turma.listDisciplinas.FirstOrDefault(d => d.sigla == discNode.Text);

                        if (turma != null)
                        {
                            string[] nome = selectedNode.Text.Split(':');
                            var aluno = turma.listAlunos.FirstOrDefault(al => al.nome == nome[0]);
                            var nota = aluno.notas.FirstOrDefault(d => d.disc == discNode.Text);
                            if (aluno != null)
                            {
                                aluno.notas.Remove(nota);
                                aluno.notas.Add(new Notas(Convert.ToDouble(txtInserir.Text), discNode.Text));
                                break;
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("Selecione um Aluno!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Selecione um Aluno!","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInserir_TextChanged(object sender, EventArgs e)
        {
            if (txtInserir.Text.Length > 0)
            {
                btnInserir.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
            }
        }

        private void txtInserir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void ProfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sair == true)
            {
                Application.Exit();
            }
        }
    }
}
