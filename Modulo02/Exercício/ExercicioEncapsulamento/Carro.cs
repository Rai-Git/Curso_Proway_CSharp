using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEncapsulamento
{
    internal class Carro
    {
        private static int _id;
        private string _marca;
        public int Id { get; set; }
        public string Marca 
        {
            get
            {
                return _marca;
            } 
            set
            {
                _marca = value;
            }
                
        }
        public string Modelo { get; set; }

        public Carro (string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }
        
        public Carro()
        {
            GeraId();
        }

        public override string ToString()
        {
            return $"ID {this.Id}\nMarca: {this.Marca}\nModelo: {this.Modelo}";
        }
        private void GeraId()
        {
            this.Id = ++ _id;
        }
      
    }
}
