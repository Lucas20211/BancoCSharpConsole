using System;
using BancoCSharpConsole.SistemaBanco;

namespace BancoCSharpConsole;

class Program
{
    static void Main(string[] args)
    {

        var conta = new Conta();
        conta.NomeBanco = "Credicomin";
        conta.NumeroConta = 1000;
        conta.Agencia = 001;
        conta.Saldo = 1000.0M;

        conta.Titular = new Titular()
        {
            Cpf = "051790199-40",
            Rg = "5260377",
            Nome = "Lucas Martins",
            Endereco = "Rua Montero"
        };

        Console.WriteLine($"Saldo atual é {conta.VerSaldo()}");

        conta.Depositar(150);

        Console.WriteLine($"Saldo após o Depósito é {conta.VerSaldo()}");

        conta.Saque(900);

        Console.WriteLine($"Saldo após Saque é {conta.VerSaldo()}");

        conta.Saque(2000);

        Console.WriteLine($"Saldo após o Saque é {conta.VerSaldo()}");


    }
}