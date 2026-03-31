namespace Exercicio5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tempo até formatura\n");
        
        DateOnly data1 = new DateOnly(2027, 06, 27);
        DateOnly data2 = DateOnly.FromDateTime(DateTime.Now);
        
        var diferencaAnos = data1.Year - data2.Year;
        var diferencaMeses = data1.Month - data2.Month;
        var diferencaDias =  data1.Day - data2.Day;
        if (diferencaDias < 0)
        {
            diferencaMeses--;
            var diasMesAnterior = DateTime.DaysInMonth(data1.AddMonths(-1).Year, data1.AddMonths(-1).Month);
            diferencaDias += diasMesAnterior;
        }

        if (diferencaMeses < 0)
        {
            diferencaAnos--;
            diferencaMeses += 12;
        }

        if (diferencaMeses < 6 && diferencaAnos == 0)
        {
            Console.WriteLine($"""
                               faltam {diferencaMeses} meses e {diferencaDias} dias
                               A reta final chegou! Prepare-se para a formatura
                               """);
        }
        else if(data1 <= data2)
        {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
        }
        else
        {
            Console.WriteLine($"faltam {diferencaAnos} anos, {diferencaMeses} meses e {diferencaDias} dias");
        }
    }
}
