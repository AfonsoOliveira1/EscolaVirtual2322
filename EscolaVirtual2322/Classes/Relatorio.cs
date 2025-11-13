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
        public string PiorAluno { get; set; }
        public List<AlunoNota> ListaAlunos { get; set; }
        public static Relatorio GerarRelatorio(Turmas turma, Professores professor)
        { 
            var re = new Relatorio
            {
                Professor = professor.nome,
                Turma = turma.nome,
                Disciplina = "",
                MediaTurma = 0.0,
                PiorAluno = "",
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
            var json = File.ReadAllText(caminho);
            return JsonSerializer.Deserialize<Relatorio>(json);
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
