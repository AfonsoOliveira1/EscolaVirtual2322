using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2322
{
    public class Turmas
    {
        private string t_Sigla;
        private string t_nome;
        public List<Alunos> listAlunos { get; set; }
        public List<Disciplina> listDisciplinas { get; set; }

        public string sigla { get { return t_Sigla; } set { t_Sigla = value; } }
        public string nome { get { return t_nome; } set { t_nome = value; } }

        public Turmas(string sigla, string nomeTurma)
        {
            this.sigla = sigla;
            this.nome = nomeTurma;
            listAlunos = new List<Alunos>();
            listDisciplinas = new List<Disciplina>();
        }
    }
}
