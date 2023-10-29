using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEncapsulamento
{
    internal class Animal
    {
        private static int _id;
        public int Id { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }

        public Animal(string especie, string raca)
        {
            this.Especie = especie;
            this.Raca = raca;
        }

        public Animal()
        {
            GeraId();
        }

        public override string ToString()
        {
            return $"ID {this.Id}\nEspecie: {this.Especie}\nRaça: {this.Raca}";
        }
        private void GeraId()
        {
            this.Id = ++_id;
        }
    }
}
