using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.models
{
    internal class Corrente: Conta1
    {
        private int _numsaque;
        public Corrente(decimal valor):base()
        {
            this.saldo = valor;

        }
        //Overrride na filha fala que esta sobreescrevendo
        public override decimal Sacar(decimal valor)
        {
            this._numsaque++;

            if(this._numsaque == 10)
            {
                this.saldo -= 0.25m;
                this._numsaque = 0;
                return valor;
            }
            return base.Sacar(valor);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
