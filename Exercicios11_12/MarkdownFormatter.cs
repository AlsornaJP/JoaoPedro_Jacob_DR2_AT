namespace Exercicios11_12;

public class MarkdownFormatter : ContatosFormatter
{
    public override void ExibirLista(string[] lista)
    {
        Console.WriteLine("## Lista de Contatos");

        foreach (var linha in lista)
        {
            var partes = linha.Split(',');

            string nome = partes[0];
            string telefone = partes[1];
            string email = partes[2];

            Console.WriteLine($"- **Nome:** {nome}");
            Console.WriteLine($"- 📞 Telefone: {telefone}");
            Console.WriteLine($"- 📧 Email: {email}");
        }
    }
}