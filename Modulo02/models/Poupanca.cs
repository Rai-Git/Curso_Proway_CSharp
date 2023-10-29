using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.models
{
    internal class Poupanca : Conta1
    {
        public Poupanca() { }

        public override decimal Sacar(decimal valor)
        {
            return base.Sacar(valor);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
