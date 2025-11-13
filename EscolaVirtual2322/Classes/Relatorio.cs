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
        public static Relatorio GerarRelatorio(Turmas turma, Professores professor, Disciplina disciplina)
        {
            bool professorLeciona = disciplina.profs.Any(p => p.id == professor.id);
            //verifica se o professor da essa disciplina
            if (!professorLeciona)
                throw new Exception($"O professor {professor.nome} não leciona a disciplina {disciplina.sigla} nesta turma.");

            var notas = turma.listAlunos
                 .SelectMany(a => a.notas)
                 .Where(n => n.disc == disciplina.sigla)
                 .Select(n => n.classi)
                 .ToList();

            double mediaTurma = notas.Any() ? notas.Average() : 0.0;//se nao houver notas, media 0

            string piorAluno = turma.listAlunos
                .Select(a => new
                {
                    Aluno = a.nome,
                    Nota = a.notas.Where(n => n.disc == disciplina.sigla).Select(n => n.classi).FirstOrDefault()
                })
                .OrderBy(an => an.Nota)
                .Select(an => an.Aluno)
                .FirstOrDefault();

            string melhorAluno = turma.listAlunos
                .Select(a => new
                {
                    Aluno = a.nome,
                    Nota = a.notas.Where(n => n.disc == disciplina.sigla).Select(n => n.classi).FirstOrDefault()
                })
                .OrderBy(an => an.Nota)
                .Select(an => an.Aluno)
                .FirstOrDefault();

            var re = new Relatorio
            {
                Professor = professor.nome,
                Turma = turma.nome,
                Disciplina = disciplina.sigla,
                MediaTurma = mediaTurma,
                MelhorAluno = melhorAluno,
                PiorAluno = piorAluno,
                ListaAlunos = new List<AlunoNota>()
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
