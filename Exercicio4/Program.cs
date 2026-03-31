using Extensions;

namespace Exercicio4;

class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Tempo até o próximo aniversário");
        Console.WriteLine("Insira sua data de nascimento\n");
        
        if (!DateOnly.TryParseExact(Console.ReadLine( ),"dd/MM/yyyy", out DateOnly data))
        {
            Console.WriteLine("Data inválida");
            return;
        }
        var dataAtual = DateOnly.FromDateTime(DateTime.Now);

        if (data > dataAtual)
        {
            Console.WriteLine("Data inválida");
            return;
        }
        var idadeEmAnos  = (dataAtual.MonthsFrom(data)) / 12;
        var proximoAniversario = data.AddYears(idadeEmAnos + 1);
        var diasAteAniversario = proximoAniversario.DayNumber - dataAtual.DayNumber;

        Console.WriteLine(diasAteAniversario < 7
            ? $"Menos de uma semana! Faltam apenas {diasAteAniversario} dias"
            : $"Faltam {diasAteAniversario} dias para o seu próximo aniversário");
    }
}