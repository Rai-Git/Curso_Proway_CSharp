using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2.models
{
    internal static class ClassConta
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static decimal Balance { get; set; }

        internal static decimal Deposita(decimal valor)
        {
            Balance += valor;
            return valor;
        }
    }
}
