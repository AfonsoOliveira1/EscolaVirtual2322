using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EscolaVirtual2322.Dados
{
    public class LogsNotasJSON
    {
        private static string path = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Dados", "LogsNotas.json");
        public List<LogsNota> logs { get; set; }
        public LogsNotasJSON()
        {
            Carregar();
        }

        public LogsNotasJSON(LogsNota log)
        {
            Carregar();    
            logs.Add(log);   
            Guardar();      
        }

        private void Carregar()
        {
            if (!File.Exists(path))
            {
                logs = new List<LogsNota>();
                return;
            }

            string conteudo = File.ReadAllText(path);
            if (conteudo == "")
                conteudo = "[]";
            logs = JsonSerializer.Deserialize<List<LogsNota>>(conteudo);
            if (logs == null)
                logs = new List<LogsNota>();
        }

        private void Guardar()
        {
            string json = JsonSerializer.Serialize(logs, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }
    public class LogsNota
    {
        public string nome { get; set; }
        public string aluno { get; set; }
        public string disciplina { get; set; }
        public string valorAntigo { get; set; }
        public string valorNovo { get; set; }
        public DateTime dataAlteracao { get; set; }
    }
}
