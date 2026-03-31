namespace Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora");

        Console.WriteLine("""
                          Qual operação deseja fazer?
                          1) Soma
                          2) Subtração
                          3) Multiplicação
                          4) Divisão
                          
                          """);
        if (!int.TryParse(Console.ReadLine(), out int opcao))
        {
            Console.WriteLine("opção inválida");
            return;
        }
        
        Console.WriteLine("\nInsíra o primeiro número");
        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Entrada inválida");
            return;
        }
        Console.WriteLine("\nInsira o segundo número");
        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            Console.WriteLine("Entrada inválida");
            return;
        }

        var resultado = 0;

        switch (opcao)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"\nO resultado é {resultado}");
                break;
            
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"\nO resultado é {resultado}");
                break;
            
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"\nO resultado é {resultado}");
                break;
            
            case 4:
                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("\nNão é possível dividir por 0");
                    break;
                }
                resultado = num1 / num2;
                Console.WriteLine($"\nO resultado é {resultado}");
                break;
        }
    }
}