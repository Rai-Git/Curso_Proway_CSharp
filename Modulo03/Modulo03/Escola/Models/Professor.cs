using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.Escola.Models
{
    internal class Professor : Pessoa
    {
        //Composição
        public List<Materia> Materias { get; private set; }
        public string Especializacao { get; set; }

        public Professor(string especializacao)
        {
            this.Especializacao = especializacao;
        }
    }
}
