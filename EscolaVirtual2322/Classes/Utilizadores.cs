using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2322
{
    public class Utilizadores
    {
        private string u_log;
        private string u_pass;

        public string log { get { return u_log; } set { u_log = value; } }
        public string pass { get { return u_pass; } set { u_pass = value; } }
        public Cargos cargo { get; set; } = Cargos.Aluno;
        public Utilizadores() { }
        public Utilizadores(string login, string password, Cargos cargo)
        {
            this.log = login;
            this.pass = password;
            this.cargo = cargo;
        }
    }
}
public enum Cargos
{
    Admin,
    Prof,
    Aluno
}