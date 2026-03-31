namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        string nome = "João Pedro";
        DateOnly dataNascimento = new DateOnly(2001, 07, 05);
        Console.WriteLine($"""
                           Olá, meu nome é {nome}
                           nasci em {dataNascimento.ToString("dd/MM/yyyy")} e estou aprendendo C#!
                           """);
    }
}