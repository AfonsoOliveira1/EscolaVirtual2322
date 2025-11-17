using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2322
{
    public class Ano
    {
        private int a_id;
        private string a_nome;
        public List<Turmas> turmas { get; set; }
        
        public int id { get { return a_id; } set { a_id = value; } }
        public string nome { get { return a_nome; } set { a_nome = value; } }

        public Ano() { }
        public Ano(int ID, string nomeAno)
        {
            this.id = ID;
            this.nome = nomeAno;
            turmas = new List<Turmas>();
        }
    }
}
