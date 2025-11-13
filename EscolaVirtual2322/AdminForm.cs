using EscolaVirtual2322.AdminFormsAdicionais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2322
{
    public partial class AdminForm : Form
    {
        bool sair = true;
        public void PopularTreeView()
        {
            tvEscola.CollapseAll();
            TreeNode inete = new TreeNode();
            inete.Text = "INETE";
            inete.ImageIndex = 0;

            for (int i = 0; i < Listas.anos.Count; i++)
            {
                TreeNode ano = new TreeNode();
                ano.Text = Listas.anos[i].nome;

                for (int j = 0; j < Listas.anos[i].turmas.Count; j++)
                {
                    TreeNode turma = new TreeNode();
                    turma.Text = Listas.anos[i].turmas[j].sigla;
                    turma.ImageIndex = turma.SelectedImageIndex = 2;

                    for (int g = 0; g < Listas.anos[i].turmas[j].listAlunos.Count; g++)
                    {
                        TreeNode aluno = new TreeNode();
                        aluno.Text = Listas.anos[i].turmas[j].listAlunos[g].nome;
                        aluno.ImageIndex = aluno.SelectedImageIndex = 3;
                        turma.Nodes.Add(aluno);
                    }

                    for (int k = 0; k < Listas.anos[i].turmas[j].listDisciplinas.Count; k++)
                    {
                        TreeNode disciplina = new TreeNode();
                        disciplina.Text = Listas.anos[i].turmas[j].listDisciplinas[k].sigla;
                        disciplina.ImageIndex = disciplina.SelectedImageIndex = 4;

                        for (int l = 0; l < Listas.anos[i].turmas[j].listDisciplinas[k].profs.Count; l++)
                        {
                            TreeNode professores = new TreeNode();
                            professores.Text = Listas.anos[i].turmas[j].listDisciplinas[k].profs[l].nome;
                            professores.ImageIndex = professores.SelectedImageIndex = 1;
                            disciplina.Nodes.Add(professores);
                        }

                        turma.Nodes.Add(disciplina);
                    }

                    ano.Nodes.Add(turma);
                }

                inete.Nodes.Add(ano);
            }
            tvEscola.Nodes.Add(inete);
        }
        public AdminForm()
        {
            InitializeComponent();
            PopularTreeView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            sair = false;
            Application.OpenForms["Login"].Show();
            this.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tvEscola.SelectedNode;
            if (tvEscola.SelectedNode != null)
            {
                switch (selectedNode.Level)
                {
                    case 0: //INETE
                        {
                            MessageBox.Show("Não pode eleminar o INETE!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    case 1: //Ano
                        {
                            var ano = Listas.anos.FirstOrDefault(a => a.nome == selectedNode.Text);
                            if (ano != null) Listas.anos.Remove(ano);
                            break;
                        }

                    case 2: //Turma
                        {
                            TreeNode anoNode = selectedNode.Parent;
                            var ano = Listas.anos.FirstOrDefault(a => a.nome == anoNode.Text);
                            if (ano != null)
                            {
                                var turma = ano.turmas.FirstOrDefault(t => t.sigla == selectedNode.Text);
                                if (turma != null) ano.turmas.Remove(turma);
                            }
                            break;
                        }

                    case 3: //Disciplina e Turma
                        {
                            TreeNode turmaNode = selectedNode.Parent;
                            TreeNode anoNode = turmaNode.Parent;

                            var ano = Listas.anos.FirstOrDefault(a => a.nome == anoNode.Text);
                            var turma = ano.turmas.FirstOrDefault(t => t.sigla == turmaNode.Text);

                            if (turma != null)
                            {
                                var aluno = turma.listAlunos.FirstOrDefault(al => al.nome == selectedNode.Text);
                                if (aluno != null)
                                {
                                    turma.listAlunos.Remove(aluno);
                                    break;
                                }

                                var disciplina = turma.listDisciplinas.FirstOrDefault(d => d.sigla == selectedNode.Text);
                                if (disciplina != null)
                                {
                                    turma.listDisciplinas.Remove(disciplina);
                                    break;
                                }
                            }
                            break;
                        }
                    case 4: //Professores
                        {
                            TreeNode disciplinaNode = selectedNode.Parent;
                            TreeNode turmaNode = disciplinaNode.Parent;
                            TreeNode anoNode = turmaNode.Parent;

                            var ano = Listas.anos.FirstOrDefault(a => a.nome == anoNode.Text);
                            var turma = ano.turmas.FirstOrDefault(t => t.sigla == turmaNode.Text);
                            var disciplina = turma.listDisciplinas.FirstOrDefault(d => d.sigla == disciplinaNode.Text);

                            if (disciplina != null)
                            {
                                var prof = disciplina.profs.FirstOrDefault(p => p.nome == selectedNode.Text);
                                if (prof != null) disciplina.profs.Remove(prof);
                            }
                            break;
                        }
                }
                PopularTreeView();
            }
            else
            {
                MessageBox.Show("Não há nada selecionado!","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAno_Click(object sender, EventArgs e)
        {
            AddAno form = new AddAno();
            form.ShowDialog();
        }

        private void btnAddTurma_Click(object sender, EventArgs e)
        {
            AddTurma form = new AddTurma();
            form.ShowDialog();
        }

        private void btnAddAlunos_Click(object sender, EventArgs e)
        {
            AddAluno form = new AddAluno();
            form.ShowDialog();
        }

        private void btnAddDisciplina_Click(object sender, EventArgs e)
        {
            AddDisciplina form = new AddDisciplina();
            form.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddProf form = new AddProf();
            form.ShowDialog();
        }

        private void btnPedidosDados_Click(object sender, EventArgs e)
        {
            PedidosDados pedidos = new PedidosDados();
            pedidos.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tvEscola.Nodes.Clear();
            PopularTreeView();
        }

        private void btnDadosProf_Click(object sender, EventArgs e)
        {
            PedidosProf pedidos = new PedidosProf();
            pedidos.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tvEscola.SelectedNode;
            if (tvEscola.SelectedNode != null)
            {
                switch (selectedNode.Level)
                {
                    case 0: //INETE
                        {
                            MessageBox.Show("Não pode editar o INETE!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    case 1: //Ano
                        {
                            var ano = Listas.anos.FirstOrDefault(a => a.nome == selectedNode.Text);
                            EditarAno anoE = new EditarAno(ano.id);
                            anoE.ShowDialog();
                            break;
                        }

                    case 2: //Turma
                        {
                            TreeNode anoNode = selectedNode.Parent;
                            var ano = Listas.anos.FirstOrDefault(a => a.nome == anoNode.Text);
                            if (ano != null)
                            {
                                var turma = ano.turmas.FirstOrDefault(t => t.sigla == selectedNode.Text);
                                if (turma != null)
                                {
                                    EditarTurma turmaE = new EditarTurma(ano.id, turma.nome);
                                    turmaE.ShowDialog();
                                }
                            }
                            break;
                        }

                    case 3: //Disciplina e Aluno
                        {
                            TreeNode turmaNode = selectedNode.Parent;
                            TreeNode anoNode = turmaNode.Parent;

                            var ano = Listas.anos.FirstOrDefault(a => a.nome == anoNode.Text);
                            var turma = ano.turmas.FirstOrDefault(t => t.sigla == turmaNode.Text);

                            if (turma != null)
                            {
                                var aluno = turma.listAlunos.FirstOrDefault(al => al.nome == selectedNode.Text);
                                if (aluno != null)
                                {
                                    EditarAluno alunoE = new EditarAluno(ano.id, turma.nome, aluno.numAluno);
                                    alunoE.ShowDialog();
                                    break;
                                }

                                var disciplina = turma.listDisciplinas.FirstOrDefault(d => d.sigla == selectedNode.Text);
                                if (disciplina != null)
                                {
                                    EditarDisc disciplinaE = new EditarDisc(ano.id, turma.nome, disciplina.sigla);
                                    disciplinaE.ShowDialog();
                                    break;
                                }
                            }
                            break;
                        }
                    case 4: //Professores
                        {
                            TreeNode disciplinaNode = selectedNode.Parent;
                            TreeNode turmaNode = disciplinaNode.Parent;
                            TreeNode anoNode = turmaNode.Parent;

                            var ano = Listas.anos.FirstOrDefault(a => a.nome == anoNode.Text);
                            var turma = ano.turmas.FirstOrDefault(t => t.sigla == turmaNode.Text);
                            var disciplina = turma.listDisciplinas.FirstOrDefault(d => d.sigla == disciplinaNode.Text);

                            if (disciplina != null)
                            {
                                var prof = disciplina.profs.FirstOrDefault(p => p.nome == selectedNode.Text);
                                if (prof != null)
                                {
                                    EditarProf profE = new EditarProf(prof.id);
                                    profE.ShowDialog();
                                }
                            }
                            break;
                        }
                }
                
            }
            else
            {
                MessageBox.Show("Não há nada selecionado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sair == true)
            {
                Application.Exit();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog)
            {
                fileDialog.Title = "Importar Dados da Escola";
                fileDialog.Filter = "Arquivo JSON|*.json";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminho = fileDialog.FileName;
                    try
                    {
                        if (caminho.EndsWith(".json"))
                        {
                            MessageBox.Show("Quer importar Alunos? Escolha não se for Importar Turmas.", "Importar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (DialogResult.Yes == DialogResult)
                            {
                                var jsonReader = System.IO.File.ReadAllText(caminho);
                                AlunosPath alunos = new AlunosPath();
                                alunos = JsonSerializer.Deserialize<AlunosPath>(jsonReader, new JsonSerializerOptions { WriteIndented = true });
                            }
                            else
                            {
                                var jsonReader = System.IO.File.ReadAllText(caminho);
                                TurmaPath turmas = new TurmaPath();
                                turmas = JsonSerializer.Deserialize<TurmaPath>(jsonReader, new JsonSerializerOptions { WriteIndented = true });
                                var ano = Listas.anos.FirstOrDefault(a => a.nome == turmas.ano);
                                var alunos = Listas.anos.SelectMany(a => a.turmas).SelectMany(t => t.listAlunos).ToList();
                                TreeNode anoNode;
                                if (ano == null)
                                {
                                    ano = new Ano(Listas.anos.Count + 1, turmas.ano);
                                    Listas.anos.Add(ano);

                                    anoNode = new TreeNode(turmas.ano);
                                    tvEscola.Nodes.Add(anoNode);
                                }
                                else
                                {
                                    anoNode = tvEscola.Nodes
                                            .Cast<TreeNode>()
                                            .FirstOrDefault(n => n.Text == ano.nome);
                                    // Percorre as turmas importadas
                                    foreach (var turmaImportada in turmas.turmas)
                                    {
                                        var turmaExistente = ano.turmas.FirstOrDefault(t => t.sigla == turmaImportada.sigla);
                                        TreeNode turmaNode;
                                        if (turmaExistente == null)
                                        {
                                            turmaExistente = new Turmas(turmaImportada.sigla, turmaImportada.nome);
                                            ano.turmas.Add(turmaExistente);

                                            turmaNode = new TreeNode(turmaImportada.sigla);
                                            turmaNode.ImageIndex = turmaNode.SelectedImageIndex = 2;
                                            anoNode.Nodes.Add(turmaNode);
                                        }
                                        else
                                            turmaNode = anoNode.Nodes
                                                    .Cast<TreeNode>()
                                                    .FirstOrDefault(n => n.Text == turmaExistente.sigla);
                                        // Importar alunos
                                        foreach (var alunoImportado in turmaImportada.listAlunos)
                                        {
                                            var alunoExistente = turmaExistente.listAlunos
                                                .FirstOrDefault(a => a.numAluno == alunoImportado.numAluno);

                                            if (alunoExistente == null)
                                            {
                                                turmaExistente.listAlunos.Add(new Alunos(
                                                    alunoImportado.numAluno,
                                                    alunoImportado.nif,
                                                    alunoImportado.nome,
                                                    alunoImportado.log,
                                                    alunoImportado.pass
                                                ));

                                                TreeNode alunoNode = new TreeNode(alunoImportado.nome);
                                                alunoNode.ImageIndex = alunoNode.SelectedImageIndex = 3;
                                                turmaNode.Nodes.Add(alunoNode);
                                            }
                                        }

                                        // Importar disciplinas
                                        foreach (var disciplinaImportada in turmaImportada.listDisciplinas)
                                        {
                                            var disciplinaExistente = turmaExistente.listDisciplinas
                                                .FirstOrDefault(d => d.sigla == disciplinaImportada.sigla);

                                            if (disciplinaExistente == null)
                                            {
                                                turmaExistente.listDisciplinas.Add(new Disciplina(
                                                    disciplinaImportada.sigla,
                                                    disciplinaImportada.nome
                                                ));

                                                TreeNode disciplinaNode = new TreeNode(disciplinaImportada.sigla);
                                                disciplinaNode.ImageIndex = disciplinaNode.SelectedImageIndex = 4;
                                                turmaNode.Nodes.Add(disciplinaNode);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Formato de arquivo não suportado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        MessageBox.Show("Dados importados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopularTreeView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao importar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public class AlunosPath
        {
            public string ano { get; set; }
            public string turma { get; set; }
        }
        public class TurmaPath
        {
            public string ano { get; set; }
            public List<Turmas> turmas { get; set; }
        }
    }
}
