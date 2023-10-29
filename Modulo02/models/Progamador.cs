using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.models
{
    internal class Progamador: Funcionario
    {

        public decimal Comissao()
        {
            return this.Salario * 0.50m;
        }
    }
}
