using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaVirtual2322.Classes;
using EscolaVirtual2322.Dados;

namespace EscolaVirtual2322
{
    public static class Listas
    {
        public static List<Ano> anos = new List<Ano>();
        public static List<Alunos> dadosA = new List<Alunos>();
        public static List<Professores> dadosP = new List<Professores>();

        static Listas()
        {
            //adiciona os anos
            anos.Add(new Ano(0, "10º"));
            anos.Add(new Ano(1, "11º"));

            //adiciona as turmas
            anos[0].turmas.Add(new Turmas("TGPSI", "Técnico de gestão e Programação de sistemas informaticos"));
            anos[0].turmas.Add(new Turmas("TSJ", "Técnico de Serviços Jurídicos"));
            anos[0].turmas.Add(new Turmas("TMA", "Técnico de Mecatrónica Automóvel"));
            anos[0].turmas.Add(new Turmas("TM", "Técnico de Mecatrónica"));
            anos[0].turmas.Add(new Turmas("TG", "Técnico de gestão"));

            anos[1].turmas.Add(new Turmas("TGPSI", "Técnico de gestão e Programação de sistemas informaticos"));
            anos[1].turmas.Add(new Turmas("TSJ", "Técnico de Serviços Jurídicos"));
            anos[1].turmas.Add(new Turmas("TMA", "Técnico de Mecatrónica Automóvel"));
            anos[1].turmas.Add(new Turmas("TM", "Técnico de Mecatrónica"));
            anos[1].turmas.Add(new Turmas("TG", "Técnico de gestão"));

            //adiciona algumas disciplinas a todas as turmas
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    anos[i].turmas[j].listDisciplinas.Add(new Disciplina("MAT", "Matemática"));
                    anos[i].turmas[j].listDisciplinas.Add(new Disciplina("PT", "Português"));
                    anos[i].turmas[j].listDisciplinas.Add(new Disciplina("AI", "Área de Integração"));
                    anos[i].turmas[j].listDisciplinas.Add(new Disciplina("ING", "Inglês"));
                    anos[i].turmas[j].listDisciplinas.Add(new Disciplina("EF", "Educação Física"));
                }   
            }

            //adiciona alguns alunos, disciplinas, professores e notas por default a turma de PSI 10º
            anos[0].turmas[0].listAlunos.Add(new Alunos("I230065",123532123, "Afonso", "afonso@inete.net", "Afonso123"));
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string rootDir = Directory.GetParent(baseDir).Parent.Parent.FullName; // sobe até à pasta do projeto
            string caminho = Path.Combine(rootDir, "Dados", "Alunos.json");
            Directory.CreateDirectory(Path.GetDirectoryName(caminho));

            DadosJSON.ImportarAlunosJSON(caminho, anos[0].turmas[0].listAlunos[0]);
            anos[0].turmas[0].listAlunos.Add(new Alunos("I220082", 265323456,"Miguel", "miguel@inete.net", "Miguel123"));
            DadosJSON.ImportarAlunosJSON(caminho, anos[0].turmas[0].listAlunos[1]);

            anos[0].turmas[0].listAlunos[0].notas.Add(new Notas(15.5, "PSI"));
            anos[0].turmas[0].listAlunos[1].notas.Add(new Notas(17.4, "PSI"));

            anos[0].turmas[0].listDisciplinas.Add(new Disciplina("PSI", "Programação de Sistemas Informaticos"));
            anos[0].turmas[0].listDisciplinas.Add(new Disciplina("SO", "Sistema Operativos"));

            anos[0].turmas[0].listDisciplinas[4].profs.Add(new Professores(0, 423123432, "JC", "jc@inete.net", "jc123"));
            anos[0].turmas[0].listDisciplinas[5].profs.Add(new Professores(1, 876543567, "JRC", "jrc@inete.net", "jrc123"));
        }
    }
}
