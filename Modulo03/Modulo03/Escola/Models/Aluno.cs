using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.Escola.Models
{
    internal class Aluno : Pessoa
    {
        private static int _id;
        public string Notas { get; set; }

        public Aluno() 
        {
            this.Id = ++_id;
        }
        public override string ToString()
        {
            return $"{this.Id}{this.Matricula}{this.Nome}{this.Sobrenome}{this.Notas }";
        }
    }
}
