namespace Exercicio10;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Jogo de adivinhação");
        Console.WriteLine("\nTente acertar o número secreto entre 1 e 50");


        int tentativas = 5;
        Random random = new Random();
        int aleatorio = random.Next(1, 51);

        while (tentativas > 0)
        {
            Console.WriteLine($"\nRestam {tentativas} tentativas");
            try
            {
                if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha > 50 || escolha < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(escolha), "Escolha um número válido");
                }
                if (escolha > aleatorio)
                {
                    Console.WriteLine($"O número secreto é MENOR que {escolha}"); 
                    tentativas--;
                }else if (escolha < aleatorio)
                { 
                    Console.WriteLine($"O número secreto é MAIOR que {escolha}"); tentativas--;
                }
                else { 
                    Console.WriteLine("Parabéns, você acertou!"); 
                    return;
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}