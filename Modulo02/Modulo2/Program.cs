using Modulo2.estrutura;
using Modulo2.models;

namespace Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Conta conta = new Conta();
            conta.id = 1;
            conta.Name = "Raí";
            conta.Saldo = 1500;

            Console.WriteLine("Digite o valor que gostaria de Depositar.");
            conta.Deposita(decimal.Parse(Console.ReadLine()));
            Console.WriteLine($"Seu saldo é de {conta.Saldo}");

            Console.WriteLine("Digite o valor que gostaria de sacar.");
            conta.Saca(decimal.Parse(Console.ReadLine()));
            Console.WriteLine($"Seu saldo é de {conta.Saldo}");

            //DTO
            ClassConta.Balance = conta.Saldo;

            Console.WriteLine($"O valor e referente a Class Conta{ClassConta.Balance}");
            Console.WriteLine($"Escreva o valor que deseja depositar");
            ClassConta.Deposita(decimal.Parse(Console.ReadLine()));

            Console.WriteLine($"O valor e referente ao deposito na Class Conta{ClassConta.Balance}");
            Console.WriteLine($"O Saldo é referente a Struct{conta.Saldo}");



           
        }
    }
}