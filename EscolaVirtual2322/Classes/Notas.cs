using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2322.Classes
{
    public class Notas
    {
        private double n_classi;
        private string n_disc;

        public double classi { get { return n_classi; } set { n_classi = value; } }
        public string disc { get { return n_disc; } set { n_disc = value; } }

        public Notas() { }
        public Notas(double classificação, string disciplina)
        {
            this.classi = classificação;
            this.disc = disciplina;
        }
    }
}
