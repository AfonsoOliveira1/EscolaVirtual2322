using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2322.Classes
{
    public class AlteraçãodeDados
    {
        public List<Alunos> alunos { get; set; }
        public List<Professores> professores { get; set; }
        public AlteraçãodeDados()
        {
            alunos = new List<Alunos>();
            professores = new List<Professores>();
        }
    }
}
