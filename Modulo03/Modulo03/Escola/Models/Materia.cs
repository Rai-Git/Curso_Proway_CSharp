using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.Escola.Models
{
    internal class Materia : BaseModel
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
