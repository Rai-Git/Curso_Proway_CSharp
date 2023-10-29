using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.models
{
    internal abstract class Conta1
    {
        private static int _id;
        public int Id { get; set;  }
        public int NumeroAgencia { get; set; }

        public decimal saldo { get; set; }

        //composicao
        public Pessoa Titular { get; set; }

        public Conta1()
        {
            this.Id = ++_id;
        }

        //Virtual na mae fala que pode ser sobreescrito
        public virtual decimal Depositar(decimal valor) 
        {
            return this.saldo += valor;
        
        }

        public virtual decimal Sacar(decimal valor)
        {
            return this.saldo -= valor;

        }
        public  bool Transferir(decimal valor, Conta1 destino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public override string ToString()
        {
            return $"{this.NumeroAgencia} {this.Id} {this.Titular} {this.saldo} ";
        }
    }
}
