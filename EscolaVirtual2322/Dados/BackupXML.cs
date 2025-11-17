using EscolaVirtual2322.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaVirtual2322.Dados
{
    public class BackupXML
    {
        public BackupXML() { }

        public static void CriarBackup(string path) 
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Ano>));
            using (var writer = new StreamWriter(path))
            {
                xmlSerializer.Serialize(writer, Listas.anos);
            }
        }

        public static void CarregarBackup(string path) 
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Ano>));
            using (var reader = new StreamReader(path))
            {
                Listas.anos = (List<Ano>)xmlSerializer.Deserialize(reader);
            }
        }
    }
}
