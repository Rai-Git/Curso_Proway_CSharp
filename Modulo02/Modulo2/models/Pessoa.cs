using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2.models
{
    internal class Pessoa
    {
        private static int _id;
        public int Id { get; set; }
        public string Nome { get; set; }

        private byte _idade;

        public byte Idade
        {
            get { return _idade; }
            set { if (value > 0) { this._idade = value; } else { this._idade = 1; } }
        }

        
        //Construtor com condição vazia.
        public Pessoa()
        {
            GeraId();
        }
        
        //Construtor com condição para inserir valores na instância da classe
        public Pessoa(string nome, byte idade)
        {
            this.Nome = nome;
            this.Idade = idade;
            GeraId();
        }

        //Apenas para leitura
        public override string ToString()
        {
            return $"ID {this.Id}\nNome {this.Nome}\n Idade {this.Idade}";
        }
        private void GeraId()
        {
            this.Id = ++_id;
        }
    }
}
