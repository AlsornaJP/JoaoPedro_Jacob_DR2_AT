namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cifrador de nome");
        
        Console.WriteLine("\nDigite seu nome: ");
        string nome = Console.ReadLine();
        while (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("\nNome inválido");
            nome = Console.ReadLine();
        }

        string resultado = "";

        foreach (char c in nome)
        {
            if (char.IsLetter(c))
            {
                char baseLetra = char.IsUpper(c) ? 'A' : 'a';
                char nova = (char)((c - baseLetra + 2) % 26 + baseLetra);
                resultado += nova;
            }
            else
            {
                resultado += c;
            }
        }

        Console.WriteLine("Cifrado: " + resultado);
    }
}