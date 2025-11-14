using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2322
{
    public class Disciplina
    {
        private string d_sigla;
        private string d_nome;
        public List<Professores> profs { get; set; }
        public string sigla { get {  return d_sigla; } set { d_sigla = value; } }
        public string nome { get { return d_nome; } set { d_nome = value; } }
        public Disciplina() { }
        public Disciplina(string sigla, string nome)
        {
            this.sigla = sigla;
            this.nome = nome;
            profs = new List<Professores>();
        }
    }
}
