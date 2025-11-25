using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;              
using System.Xml.Linq;

namespace EscolaVirtual2322.Classes
{
    public class Relatorio
    {
        public string Professor { get; set; }
        public string Turma { get; set; } 
        public string Disciplina { get; set; }
        public double MediaTurma { get; set; }
        public string MelhorAluno { get; set; }
        public string PiorAluno { get; set; }
        public List<AlunoNota> ListaAlunos { get; set; }
        public static Relatorio GerarRelatorio(Turmas turma, Professores professor)
        {
            var disciplinas = turma.listDisciplinas
             .Where(d => d.profs.Any(p => p.id == professor.id))
             .ToList();

            if (disciplinas == null) 
                throw new Exception($"O professor {professor.nome} não leciona nenhuma disciplina nesta turma.");

            List<AlunoNota> listaAlunosNotas = new List<AlunoNota>();
            foreach (var disciplina in disciplinas)
            {
                var notas = turma.listAlunos
                 .SelectMany(a => a.notas)
                 .Where(n => n.disc == disciplina.sigla)
                 .Select(n => n.classi)
                 .ToList();

                double mediaTurma = notas.Any() ? notas.Average() : 0.0;//se nao houver notas, media 0

                foreach (var aluno in turma.listAlunos)
                {
                    var notaCheck = aluno.notas.FirstOrDefault(n => n.disc == disciplina.sigla);
                    if(notaCheck == null) 
                        throw new Exception($"Este aluno {aluno.nome} nao tem nota na disciplina de {disciplina.sigla}"); //pula alunos sem nota na disciplina

                    var nota = aluno.notas.Where(n => n.disc == disciplina.sigla).Select(c => c.classi).First();
                    listaAlunosNotas.Add(new AlunoNota { Aluno = aluno.nome, Nota = nota});
                }
            }
            if(listaAlunosNotas.Count == 0)
                throw new Exception($"Não há notas registradas para a turma {turma.nome} nas disciplinas lecionadas pelo professor {professor.nome}.");

            var mediasPorAluno = listaAlunosNotas
                .GroupBy(an => an.Aluno)
                .Select(g => new
                {
                    Aluno = g.Key,
                    Media = g.Average(an => an.Nota)
                })
                .ToList();
            var maxMedia = mediasPorAluno.Max(a => a.Media);
            var melhores = mediasPorAluno.Where(a => a.Media == maxMedia).Select(a => a.Aluno).ToList();

            var minMedia = mediasPorAluno.Min(a => a.Media);
            var piores = mediasPorAluno.Where(x => x.Media == minMedia).Select(a => a.Aluno).ToList();
            var re = new Relatorio
            {
                Professor = professor.nome,
                Turma = turma.nome,
                Disciplina = string.Join(", ", disciplinas.Select(d => d.sigla)),
                MediaTurma = Math.Round(listaAlunosNotas.Average(x => x.Nota), 2),
                MelhorAluno = string.Join(", ", melhores),
                PiorAluno = string.Join(", ", piores),
                ListaAlunos = listaAlunosNotas
            };
            return re;
        }
        public static void ExportarRelatorioJSON(Relatorio relatorio, string caminho)
        {
            var json = JsonSerializer.Serialize(relatorio, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminho, json);
        }
        public static void ExportarRelatorioXML(Relatorio relatorio, string caminho)
        {
            // Configurações do XML (indentação, formatação)
            XmlWriterSettings xmlSettings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "   "
            };

            // Cria o arquivo XML com as configurações acima
            using (XmlWriter xmlOut = XmlWriter.Create(caminho, xmlSettings))
            {
                xmlOut.WriteStartDocument();                    // Início do documento XML
                xmlOut.WriteComment("Relatório da turma");      // Comentário opcional

                xmlOut.WriteStartElement("Relatorio");          // Elemento raiz

                // Escrita de elementos simples
                xmlOut.WriteElementString("Professor", relatorio.Professor);
                xmlOut.WriteElementString("Turma", relatorio.Turma);
                xmlOut.WriteElementString("Disciplina", relatorio.Disciplina);
                xmlOut.WriteElementString("MediaTurma", relatorio.MediaTurma.ToString());
                xmlOut.WriteElementString("MelhorAluno", relatorio.MelhorAluno);
                xmlOut.WriteElementString("PiorAluno", relatorio.PiorAluno);

                xmlOut.WriteStartElement("ListaAlunos");        // Lista de alunos

                // Escreve cada aluno como elemento XML
                foreach (var aluno in relatorio.ListaAlunos)
                {
                    xmlOut.WriteStartElement("Aluno");
                    xmlOut.WriteElementString("Nome", aluno.Aluno);
                    xmlOut.WriteElementString("Nota", aluno.Nota.ToString());
                    xmlOut.WriteEndElement();
                }

                xmlOut.WriteEndElement();   // ListaAlunos
                xmlOut.WriteEndElement();   // Relatorio
                xmlOut.WriteEndDocument();  // Final do XML
            }
        }
        public static Relatorio ImportarRelatorioJSON(string caminho)
        {
            var json1 = File.ReadAllText(caminho);
            return JsonSerializer.Deserialize<Relatorio>(json1);
        }

        public static Relatorio ImportarRelatorioXML(string caminho)
        {
            XDocument doc = XDocument.Load(caminho);   // Carrega o XML inteiro para memória

            var rel = new Relatorio
            {
                // Lê elementos simples do XML
                Professor = (string)doc.Root.Element("Professor") ?? "",
                Turma = (string)doc.Root.Element("Turma") ?? "",
                Disciplina = (string)doc.Root.Element("Disciplina") ?? "",
                MediaTurma = Convert.ToDouble((string)doc.Root.Element("MediaTurma") ?? "0"),
                MelhorAluno = (string)doc.Root.Element("MelhorAluno") ?? "",
                PiorAluno = (string)doc.Root.Element("PiorAluno") ?? "",

                // Converte cada <Aluno> numa lista de objetos
                ListaAlunos = doc.Root.Element("ListaAlunos")
                    .Elements("Aluno")
                    .Select(a => new Relatorio.AlunoNota
                    {
                        Aluno = (string)a.Element("Nome") ?? "",
                        Nota = Convert.ToDouble((string)a.Element("Nota") ?? "0")
                    })
                    .ToList()
            };

            return rel;
        }

        public static void GerarRelatorioAlunos(Alunos aluno, string caminho)
        {
            var notas = aluno.notas;
            var relatorioAluno = new
            {
                Aluno = aluno.nome,
                Notas = notas.Select(n => new { Disciplina = n.disc, Nota = n.classi }).ToList(),
                MediaFinal = notas.Any() ? notas.Average(n => n.classi) : 0.0
            };
            var json = JsonSerializer.Serialize(relatorioAluno, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Path.Combine(caminho, $"{aluno.nome}_relatorio.json"), json);
        }

        public class AlunoNota
        {
            public string Aluno { get; set; }
            public double Nota { get; set; }
            public string Modulo { get; set; }
        }
    }
}
