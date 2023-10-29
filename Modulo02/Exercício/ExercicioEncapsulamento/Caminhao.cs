using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEncapsulamento
{
    internal class Caminhao
    {
        private static int _id;
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Caminhao(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public Caminhao()
        {
            GeraId();
        }

        public override string ToString()
        {
            return $"ID {this.Id}\nMarca: {this.Marca}\nModelo: {this.Modelo}";
        }
        private void GeraId()
        {
            this.Id = ++_id;
        }
    }
}
