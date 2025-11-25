using EscolaVirtual2322.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;

namespace EscolaVirtual2322.Dados
{
    public class BackupXML
    {
        public BackupXML() { }

        public static void CriarBackup(string path) 
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = Encoding.UTF8
            };

            using (XmlWriter writer = XmlWriter.Create(path, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("ArrayOfAno");

                foreach (Ano ano in Listas.anos)
                {
                    writer.WriteStartElement("Ano");

                    writer.WriteStartElement("turmas");
                    foreach (Turmas t in ano.turmas)
                    {
                        writer.WriteStartElement("Turmas");

                        // listAlunos
                        writer.WriteStartElement("listAlunos");
                        foreach (Alunos a in t.listAlunos)
                        {
                            writer.WriteStartElement("Alunos");

                            writer.WriteElementString("log", a.log ?? "");
                            writer.WriteElementString("pass", a.pass ?? "");
                            writer.WriteElementString("cargo", a.cargo.ToString());

                            // notas
                            writer.WriteStartElement("notas");
                            foreach (Notas n in a.notas)
                            {
                                writer.WriteStartElement("Notas");
                                writer.WriteElementString("classi", n.classi.ToString(CultureInfo.InvariantCulture));
                                writer.WriteElementString("disc", n.disc ?? "");
                                writer.WriteEndElement(); // Notas
                            }
                            writer.WriteEndElement(); // notas

                            // mensagens
                            writer.WriteStartElement("mensagens");
                            if (a.mensagens != null)
                            {
                                foreach (string msg in a.mensagens)
                                    writer.WriteElementString("msg", msg ?? "");
                            }
                            writer.WriteEndElement(); // mensagens

                            writer.WriteElementString("numAluno", a.numAluno ?? "");
                            writer.WriteElementString("nif", a.nif.ToString());
                            writer.WriteElementString("nome", a.nome ?? "");
                            writer.WriteElementString("saldo", a.saldo.ToString(CultureInfo.InvariantCulture));

                            writer.WriteEndElement(); // Alunos
                        }
                        writer.WriteEndElement(); // listAlunos

                        // listDisciplinas
                        writer.WriteStartElement("listDisciplinas");
                        foreach (Disciplina d in t.listDisciplinas)
                        {
                            writer.WriteStartElement("Disciplina");

                            writer.WriteStartElement("profs");
                            foreach (Professores p in d.profs)
                            {
                                writer.WriteStartElement("Professores");
                                writer.WriteElementString("log", p.log ?? "");
                                writer.WriteElementString("pass", p.pass ?? "");
                                writer.WriteElementString("cargo", p.cargo.ToString());
                                writer.WriteElementString("id", p.id.ToString());
                                writer.WriteElementString("nif", p.nif.ToString());
                                writer.WriteElementString("nome", p.nome ?? "");
                                writer.WriteEndElement(); // Professores
                            }
                            writer.WriteEndElement(); // profs

                            writer.WriteElementString("sigla", d.sigla ?? "");
                            writer.WriteElementString("nome", d.nome ?? "");

                            writer.WriteEndElement(); // Disciplina
                        }
                        writer.WriteEndElement(); // listDisciplinas

                        writer.WriteElementString("sigla", t.sigla ?? "");
                        writer.WriteElementString("nome", t.nome ?? "");

                        writer.WriteEndElement(); // Turmas
                    }
                    writer.WriteEndElement(); // turmas

                    writer.WriteElementString("id", ano.id.ToString());
                    writer.WriteElementString("nome", ano.nome ?? "");

                    writer.WriteEndElement(); // Ano
                }

                writer.WriteEndElement(); // ArrayOfAno
                writer.WriteEndDocument();
            }
        }

        public static void CarregarBackup(string path) 
        {
            var anos = new List<Ano>();

            using (XmlReader reader = XmlReader.Create(path))
            {
                Ano currentAno = null;
                Turmas currentTurma = null;
                Alunos currentAluno = null;
                Disciplina currentDisc = null;
                Professores currentProf = null;
                Notas currentNota = null;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        string name = reader.Name;

                        // Create objects on start elements
                        if (name == "Ano")
                        {
                            currentAno = new Ano();
                            currentAno.turmas = new List<Turmas>();
                        }
                        else if (name == "Turmas")
                        {
                            currentTurma = new Turmas();
                            currentTurma.listAlunos = new List<Alunos>();
                            currentTurma.listDisciplinas = new List<Disciplina>();
                        }
                        else if (name == "Alunos")
                        {
                            currentAluno = new Alunos();
                            currentAluno.notas = new List<Notas>();
                            currentAluno.mensagens = new List<string>();
                        }
                        else if (name == "Notas")
                        {
                            currentNota = new Notas();
                        }
                        else if (name == "Disciplina")
                        {
                            currentDisc = new Disciplina();
                            currentDisc.profs = new List<Professores>();
                        }
                        else if (name == "Professores")
                        {
                            currentProf = new Professores();
                        }
                        else
                        {
                            // For leaf nodes: read content as string first, then parse safely
                            switch (name)
                            {
                                case "log":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        if (currentAluno != null && currentProf == null) currentAluno.log = val;
                                        else if (currentProf != null) currentProf.log = val;
                                    }
                                    break;

                                case "pass":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        if (currentAluno != null && currentProf == null) currentAluno.pass = val;
                                        else if (currentProf != null) currentProf.pass = val;
                                    }
                                    break;

                                case "cargo":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        if (!string.IsNullOrEmpty(val))
                                        {
                                            Cargos parsed;
                                            if (Enum.TryParse(val, out parsed))
                                            {
                                                if (currentAluno != null && currentProf == null) currentAluno.cargo = parsed;
                                                if (currentProf != null) currentProf.cargo = parsed;
                                            }
                                        }
                                    }
                                    break;

                                case "classi":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        double d;
                                        if (double.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out d))
                                        {
                                            if (currentNota != null) currentNota.classi = d;
                                        }
                                        else
                                        {
                                            if (currentNota != null) currentNota.classi = 0.0; // fallback
                                        }
                                    }
                                    break;

                                case "disc":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        if (currentNota != null) currentNota.disc = val;
                                        else if (currentDisc != null) { /* possible conflict name - but likely for Notas */ }
                                    }
                                    break;

                                case "msg":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        if (currentAluno != null) currentAluno.mensagens.Add(val);
                                    }
                                    break;

                                case "numAluno":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        if (currentAluno != null) currentAluno.numAluno = val;
                                    }
                                    break;

                                case "nif":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        int parsed;
                                        if (int.TryParse(val, out parsed))
                                        {
                                            if (currentAluno != null) currentAluno.nif = parsed;
                                            else if (currentProf != null) currentProf.nif = parsed;
                                        }
                                        else
                                        {
                                            // leave default 0 if parse fails
                                        }
                                    }
                                    break;

                                case "nome":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        if (currentDisc != null && currentProf == null && currentAluno == null && currentTurma != null)
                                        {
                                            // this case is ambiguous; prefer to assign based on which object exists
                                            currentDisc.nome = val;
                                        }
                                        else if (currentProf != null) currentProf.nome = val;
                                        else if (currentAluno != null) currentAluno.nome = val;
                                        else if (currentTurma != null && currentDisc == null) currentTurma.nome = val;
                                        else if (currentAno != null && currentTurma == null) currentAno.nome = val;
                                    }
                                    break;

                                case "saldo":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        double parsed;
                                        if (double.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out parsed))
                                        {
                                            if (currentAluno != null) currentAluno.saldo = parsed;
                                        }
                                        else
                                        {
                                            if (currentAluno != null) currentAluno.saldo = 0.0;
                                        }
                                    }
                                    break;

                                case "sigla":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        if (currentDisc != null) currentDisc.sigla = val;
                                        else if (currentTurma != null) currentTurma.sigla = val;
                                    }
                                    break;

                                case "id":
                                    {
                                        string val = reader.IsEmptyElement ? "" : reader.ReadElementContentAsString();
                                        int parsed;
                                        if (int.TryParse(val, out parsed))
                                        {
                                            if (currentProf != null) currentProf.id = parsed;
                                            else if (currentAno != null && currentTurma == null) currentAno.id = parsed;
                                        }
                                    }
                                    break;
                            } // end switch leaf
                        } // end else
                    } // end if Element

                    // Handle end elements: add constructed objects into parents
                    if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        string endName = reader.Name;
                        if (endName == "Notas")
                        {
                            if (currentAluno != null && currentNota != null)
                            {
                                currentAluno.notas.Add(currentNota);
                                currentNota = null;
                            }
                        }
                        else if (endName == "Professores")
                        {
                            if (currentDisc != null && currentProf != null)
                            {
                                currentDisc.profs.Add(currentProf);
                                currentProf = null;
                            }
                        }
                        else if (endName == "Disciplina")
                        {
                            if (currentTurma != null && currentDisc != null)
                            {
                                currentTurma.listDisciplinas.Add(currentDisc);
                                currentDisc = null;
                            }
                        }
                        else if (endName == "Alunos")
                        {
                            if (currentTurma != null && currentAluno != null)
                            {
                                currentTurma.listAlunos.Add(currentAluno);
                                currentAluno = null;
                            }
                        }
                        else if (endName == "Turmas")
                        {
                            if (currentAno != null && currentTurma != null)
                            {
                                currentAno.turmas.Add(currentTurma);
                                currentTurma = null;
                            }
                        }
                        else if (endName == "Ano")
                        {
                            if (currentAno != null)
                            {
                                anos.Add(currentAno);
                                currentAno = null;
                            }
                        }
                    }
                } // end while reader.Read()
            } // end using reader

            Listas.anos = anos;
        }
    }
}
