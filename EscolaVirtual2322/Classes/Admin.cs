using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual2322
{
    public class Admin : Utilizadores
    {
        public Admin() : base("admin", "admin", Cargos.Admin) { }
    }
}
