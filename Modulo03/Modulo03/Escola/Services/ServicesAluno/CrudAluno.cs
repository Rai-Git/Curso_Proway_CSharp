using Modulo03.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.Escola.Services.ServicesAluno
{
    internal class CrudAluno : IAluno
    {
        private static List<Aluno> _alunos= new List<Aluno>();
        public void Create(Aluno aluno)
        {
            _alunos.Add(aluno);
        }

        public void Delete(int id)
        {
            Aluno alunoparadeletar = _alunos.FirstOrDefault(a => a.Id == id);
            if (alunoparadeletar != null)
            {
                _alunos.Remove(alunoparadeletar);
            }
            else
            {
                Console.WriteLine("Aluno não encontrado");
            }
        }

        public List<Aluno> Read()
        {
            foreach(var aluno in _alunos) 
            {
                Console.WriteLine($"Id {aluno.Id}\nMatricula {aluno.Matricula}\nNome {aluno.Nome}\nSobrenome {aluno.Sobrenome}\n Notas {aluno.Notas}");
            }
            return _alunos;
        }

        public void Update(Aluno model)
        {
            //Função que manipula lista
            Aluno alunoexistente = _alunos.FirstOrDefault(a => a.Id == model.Id);
            if(alunoexistente != null) 
            {
                alunoexistente.Nome = model.Nome;
                alunoexistente.Sobrenome = model.Sobrenome;
                alunoexistente.Notas = model.Notas;
            }
            else
            {
                Console.WriteLine("Aluno não encontrado");
            }
        }
    }
}
