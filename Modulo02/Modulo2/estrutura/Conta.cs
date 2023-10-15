using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2.estrutura
{
    internal class Conta
    {
        public int id { get; set; }
        public string Name { get; set; }
        public decimal Saldo { get; set; }

        public decimal Deposita(decimal valor)
        {
            this.Saldo += valor;
            return valor;
        }

        public decimal Saca(decimal valor)
        {
            this.Saldo -= valor;
            return valor;
        }

          
    }
}
