using Modulo03.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.Escola.Services.ServicesAluno
{
    internal interface IAluno
    {
        void Create(Aluno model);
        List<Aluno> Read();
        void Update(Aluno model);
        void Delete(int id);
    }
}
