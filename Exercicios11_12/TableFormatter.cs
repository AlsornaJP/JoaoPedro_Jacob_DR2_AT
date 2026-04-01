namespace Exercicios11_12;

public class TableFormatter : ContatosFormatter
{
    public override void ExibirLista(string[] lista)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("| Nome | Telefone | Email |");
        Console.WriteLine("----------------------------------------");

        foreach (var linha in lista)
        {
            var partes = linha.Split(',');

            string nome = partes[0];
            string telefone = partes[1];
            string email = partes[2];

            Console.WriteLine($"| {nome} | {telefone} | {email} |");
        }

        Console.WriteLine("----------------------------------------");
    }
}