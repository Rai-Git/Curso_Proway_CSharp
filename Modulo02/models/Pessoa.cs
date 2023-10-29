using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.models
{
    internal class Pessoa
    {
        private static int _id;
        public int Id { get; private set; }

        private string _nome;
        public string Nome {
            get {
                return _nome;
                 }
            set
            {

                while (value.Length <= 2) 
                {
                    Console.Write("digite um nome valido >> ");
                    value = Console.ReadLine();
                }  

                this._nome = value;

            }
        }

        private byte _idade;
        public byte Idade {

            get { return _idade;  }
            
            set { 
                while (value <= 0) 
                {
                    Console.Write("digite uma idade valida >> ");
                    value = byte.Parse(Console.ReadLine());
                }
                this._idade = value; 
            }
         }
        //Construtor com condicao vazia
        public Pessoa() 
        {
            GeraId();

        }
        //Construtor com condicao para inserir  valores na instancia da classe
        public Pessoa(string nome, byte idade) 
        {
            this.Nome = nome;
            this.Idade = idade;
            GeraId();

        }
        //Apenas para leitura
        public override string ToString()
        {
            return $"ID {this.Id}\nNome {this.Nome}\nIdade {this.Idade}";
        }
        private void GeraId() 
        {
            this.Id = ++_id;
        }

    }
}
