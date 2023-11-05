using Modulo03.Escola.Models;
using Modulo03.Escola.Services.ServicesAluno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.Escola.Views
{
    internal class View
    {
        public void Main()
        {
            string continuar;
            do
            {
                Console.WriteLine("1- Deseja manipular aluno");
                Console.WriteLine("2- Deseja manipular Professor");
                Console.WriteLine("2- Digite o número que representa o que deseja fazer");
                byte var = byte.Parse(Console.ReadLine());

                switch (var)
                {
                    case 1:
                        CrudAluno crudAluno = new CrudAluno();
                        Aluno aluno = new Aluno();
                        Console.WriteLine("Seja bem vido á area do aluno");
                        Console.WriteLine("Oque deseja fazer\n1- Criar\n2- Listar\n3- Alterar\n4-Deletar\n>> ");
                        byte cond = byte.Parse(Console.ReadLine());
                        if(cond == 1) 
                        {
                            Console.Write("Digite a Matricula do aluno.");
                            aluno.Matricula = Console.ReadLine();
                            Console.Write("Digite o nome do aluno.");
                            aluno.Nome = Console.ReadLine();
                            Console.Write("Digite sobrenome do aluno.");
                            aluno.Sobrenome = Console.ReadLine();
                            Console.Write("Digite as notas do aluno separando por virgula ex(10, 2).");
                            aluno.Notas = Console.ReadLine();

                            crudAluno.Create(aluno);
                        }
                        else if(cond == 2)
                        {
                            Console.WriteLine("============================ Lista de Alunos ===================================");
                            crudAluno.Read();
                        }
                        else if(cond == 3)
                        {
                            Console.Write("Alterar");
                        }
                        else if(cond == 4)
                        {
                            Console.Write("Deletar.");
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida.");
                        }

                        break;
                    case 2:
                        break;
                }

                Console.WriteLine("Deseja continuar?\nsim\nnão\n>>");
                continuar = Console.ReadLine();

            }while(continuar.ToLower() == "sim");
        }
    }
}
