using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.models
{
    internal class Gerenciador
    {
        public decimal TotalComissaoPaga { get;  private set; }

        //Sobre escrita metodo
        public void Registrar(Funcionario funcionario) 
        {
            this.TotalComissaoPaga += funcionario.Comissao();
        }
    }
}
