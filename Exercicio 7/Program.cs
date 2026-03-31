namespace Exercicio_7;

class Program
{
    static void Main(string[] args)
    {
        Conta contaBancaria = new Conta("João Pedro");
        
        contaBancaria.Depositar(5000);
        contaBancaria.Sacar(5100);
        contaBancaria.Sacar(3000);
        contaBancaria.ExibirSaldo();
    }
}