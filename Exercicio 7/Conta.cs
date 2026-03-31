namespace Exercicio_7;

public class Conta
{
    public Conta(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    public string Titular { get; set; }
    private double Saldo { get; set; }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero");
            return;
        }
        Saldo += valor;
        Console.WriteLine($"""
                           
                           ----------
                           Depósito de R${valor} realizado com sucesso
                           Saldo atual: R${Saldo}
                           ----------
                           
                           """);
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque");;
            return;
        }
        
        Saldo -= valor;
        Console.WriteLine($"""
                           
                           ----------
                           Saque de R${valor} realizado com sucesso
                           Saldo atual: R${Saldo}
                           ----------
                           
                           """);
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"\nO saldo atual é de: R${Saldo}");
    }
}
     