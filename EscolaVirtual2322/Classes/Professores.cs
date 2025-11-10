using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2322
{
    public class Professores : Utilizadores
    {
        private int p_id;
        private int p_NIF;
        private string p_nome;

        public int id { get { return p_id; } set { p_id = value; } }
        public int nif { get { return p_NIF; } set { p_NIF = value; } }
        public string nome { get { return p_nome; } set { p_nome = value; } }

        public Professores(int ID, int NIF, string name, string login, string password) : base(login, password, Cargos.Prof)
        {
            this.id = ID;
            this.nif = NIF;
            this.nome = name;
        }
    }
}
