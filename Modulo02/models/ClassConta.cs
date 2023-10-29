using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.models
{
    internal static class ClassConta
    {
        public static int Id { get; set; }
        public static string Nome { get; set;}
        public static decimal Saldo { get; set; }
        internal static decimal Deposita(decimal valor)
        {
            Saldo += valor;
            return valor;

        }

     
    }
    

}
