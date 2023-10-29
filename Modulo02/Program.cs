using Modulo02.models;
using System.Runtime;
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Andre";

Poupanca poupanca= new Poupanca();

poupanca.saldo = 2050.0m;

Console.WriteLine(poupanca.Sacar(50));
Console.WriteLine(poupanca.Depositar(150));




Corrente corrente = new Corrente(1500.0m);
Console.WriteLine(corrente.Depositar(500));
Console.WriteLine(corrente.Sacar(100));
Console.WriteLine(corrente.Transferir(1000.0m, poupanca));

Console.WriteLine(poupanca);


