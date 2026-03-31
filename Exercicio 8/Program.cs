namespace Exercicio_8;

class Program
{
    static void Main(string[] args)
    {
        Funcionario joao = new Funcionario("João Pedro", "Estagiário", 2000);
        Funcionario alberto = new Gerente("Alberto", "Gerente", 5000);

        Console.WriteLine($"O salário de João é R${joao.CalcularSalario()}");
        Console.WriteLine($"O salário de Alberto é R${alberto.CalcularSalario()}");

    }
}