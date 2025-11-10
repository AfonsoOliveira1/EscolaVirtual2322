using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EscolaVirtual2322.Dados
{
    public class UsersJSON
    {
        private string path = Path.Combine("Dados", "Users.json");
        private List<Utilizadores> users;
        private JsonSerializerOptions options = new JsonSerializerOptions{ WriteIndented = true};

        public UsersJSON()
        {
            Directory.CreateDirectory("Dados");

            string json = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(json))
            {
                users = new List<Utilizadores>();
                File.WriteAllText(path, "[]");
            }
            else
            {
                users = JsonSerializer.Deserialize<List<Utilizadores>>(json, options) ?? new List<Utilizadores>();
            }
        }
        public void AdicionarUtilizador(Utilizadores user)
        {
            if (!users.Any(u => u.log == user.log))
            {
                users.Add(user);
                Salvar();
            }
        }

        public void RemoverUtilizador(Utilizadores user)
        {
            users.Remove(user);
            Salvar();
        }

        public void Salvar()
        {
            string jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, jsonString);
        }

        public List<Utilizadores> ObterUtilizadores()
        {
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<Utilizadores>>(jsonString, options) ?? new List<Utilizadores>();
            }
            return users;
        }

        public bool Login(string login, string password)
        {
            return users.Any(u => u.log == login && u.pass == password);
        }
        public Utilizadores ObterUtilizador(string login, string password)
        {
            return users.FirstOrDefault(u => u.log == login && u.pass == password);
        }
    }
}
