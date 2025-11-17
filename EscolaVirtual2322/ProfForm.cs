using EscolaVirtual2322.Classes;
using EscolaVirtual2322.Dados;
using EscolaVirtual2322.ProfFormsAdicionais;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
                        var prof = disciplina.profs.FirstOrDefault(p => p.id == id);

                        if (turma != null)
                        {
                            string[] nome = selectedNode.Text.Split(':');
                            var aluno = turma.listAlunos.FirstOrDefault(al => al.nome == nome[0]);
                            var nota = aluno.notas.FirstOrDefault(d => d.disc == discNode.Text);
                            if (aluno != null)
                            {
                                LogsNota log = new LogsNota
                                {
                                    nome = prof.nome,
                                    aluno = aluno.nome,
                                    disciplina = discNode.Text,
                                    valorAntigo = nota != null ? Convert.ToString(nota.classi) : "Sem Nota",
                                    valorNovo = txtInserir.Text,
                                    dataAlteracao = DateTime.Now
                                };
                                LogsNotasJSON logs = new LogsNotasJSON(log);
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

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();

            using (OpenFileDialog saveFile = new OpenFileDialog())
            {
                saveFile.Title = "Importar Relatório";
                saveFile.Filter = "Arquivos JSON (*.json)|*.json|Arquivos XML (*.xml)|*.xml";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if(saveFile.FileName.EndsWith(".json"))
                    {
                        relatorio = Relatorio.ImportarRelatorioJSON(saveFile.FileName);
                    }
                    else if (saveFile.FileName.EndsWith(".xml"))
                    {
                        relatorio = Relatorio.ImportarRelatorioXML(saveFile.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Selecione um ficheiro .json ou .xml válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Professor: {relatorio.Professor}");
                    sb.AppendLine($"Turma: {relatorio.Turma}");
                    sb.AppendLine($"Disciplina: {relatorio.Disciplina}");
                    sb.AppendLine($"Média da Turma: {relatorio.MediaTurma}");
                    sb.AppendLine($"Melhor Aluno: {relatorio.MelhorAluno}");
                    sb.AppendLine($"Pior Aluno: {relatorio.PiorAluno}");
                    sb.AppendLine("Lista de Alunos e Notas:");
                    foreach(var alunoNota in relatorio.ListaAlunos)
                    {
                        sb.AppendLine($"{alunoNota.Aluno}: {alunoNota.Nota}");
                    }
                    MessageBox.Show(sb.ToString(), "Relatório Importado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            TreeNode selectednode = tvTurmas.SelectedNode;
            switch (selectednode.Level)
            {
                case 1:
                    var turma = Listas.anos
                        .SelectMany(a => a.turmas)
                        .FirstOrDefault(t => t.sigla == selectednode.Text);

                    var prof = turma.listDisciplinas
                        .SelectMany(d => d.profs)
                        .FirstOrDefault(p => p.id == id);
                    if(turma != null && prof != null)
                    {
                        Relatorio relatorioTurma = Relatorio.GerarRelatorio(turma, prof);
                        MessageBox.Show("Queres em JSON?", "Relatorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(DialogResult.Yes == DialogResult)
                        {
                            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                            {
                                dialog.Description = "Escolha a pasta para salvar o relatório";
                                dialog.ShowNewFolderButton = true;
                                DialogResult result = dialog.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                                {
                                    string caminhoPasta = dialog.SelectedPath;
                                    string caminhoArquivo = Path.Combine(caminhoPasta, "relatorio.json");
                                    Relatorio.ExportarRelatorioJSON(relatorioTurma, caminhoArquivo);
                                }
                            }
                        }
                        else
                        {
                            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                            {
                                dialog.Description = "Escolha a pasta para salvar o relatório";
                                dialog.ShowNewFolderButton = true;
                                DialogResult result = dialog.ShowDialog();
                                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                                {
                                    string caminhoPasta = dialog.SelectedPath;
                                    string caminhoArquivo = Path.Combine(caminhoPasta, "relatorio.xml");
                                    Relatorio.ExportarRelatorioXML(relatorioTurma, caminhoArquivo);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma Turma válida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
    }
}
