using System;



namespace BancoCSharpConsole.SistemaBanco;
public class Conta
{
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public string NomeBanco { get; set; }
    public Titular Titular { get; set; }


    public Decimal Saldo { get; set; }

    public Decimal VerSaldo()
    {
        return Saldo;
    }
    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public void Saque(decimal valor)
    {
        if(valor <= Saldo)
            Saldo -= valor;
        else
        Console.WriteLine("Saldo insuficiente!"); 

    }



}