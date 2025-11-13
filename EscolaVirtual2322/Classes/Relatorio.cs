using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;


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
            var xmlSerializer = new XmlSerializer(typeof(Relatorio));
            using (var writer = new StreamWriter(caminho))
            {
                xmlSerializer.Serialize(writer, relatorio);
            }
        }
        public static Relatorio ImportarRelatorioJSON(string caminho)
        {
            var json1 = File.ReadAllText(caminho);
            return JsonSerializer.Deserialize<Relatorio>(json1);
        }

        public static Relatorio ImportarRelatorioXML(string caminho)
        {
            var xmlSerializer = new XmlSerializer(typeof(Relatorio));
            using (var reader = new StreamReader(caminho))
            {
                return (Relatorio)xmlSerializer.Deserialize(reader);
            }
        }

        public class AlunoNota
        {
            public string Aluno { get; set; }
            public double Nota { get; set; }
            public string Modulo { get; set; }
        }
    }
}
