using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EscolaVirtual2322.Dados
{
    public class DadosJSON
    {
        public static void ImportarAlunosJSON(string caminho, Alunos alunos)
        {
            try
            {
                string json = JsonSerializer.Serialize(alunos, new JsonSerializerOptions { WriteIndented = true});

                File.WriteAllText(caminho, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao guardar os dados das turmas: " + ex.Message + ex.Source);
            }
        }
    }
}
