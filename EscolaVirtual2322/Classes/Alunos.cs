using EscolaVirtual2322.Classes;
using EscolaVirtual2322.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2322
{
    public class Alunos : Utilizadores
    {
        private string a_NumAluno;
        private int a_NIF;
        private string a_nome;
        private double a_saldo = 0;

        public List<Notas> notas { get; set; }
        public List<string> mensagens { get; set; }

        public string numAluno { get { return a_NumAluno; } set { a_NumAluno = value; } }
        public int nif { get { return a_NIF; } set { a_NIF = value; } }
        public string nome { get { return a_nome; } set { a_nome = value; } }
        public double saldo 
        { 
            get { return a_saldo; } 
            set
            {
                if (value >= 0)
                {
                    a_saldo = value;
                }
                else
                {
                    throw new Exception("Saldo Invalido!");
                }
            }
        }

        public Alunos(string NumeroDeAluno, int NIF, string name, string login, string password) : base(login, password)
        {
            this.numAluno = NumeroDeAluno;
            this.nif = NIF;
            this.nome = name;
            notas = new List<Notas>();
            mensagens = new List<string>();
        }
    }
}
