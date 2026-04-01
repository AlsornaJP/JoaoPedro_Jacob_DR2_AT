namespace Exercicios11_12;

public class RawTextFormatter : ContatosFormatter
{
    public override void ExibirLista(string[] lista)
    {
        Console.WriteLine("=== Contatos registrados ===");
        foreach (var linha in lista)
        {
            var partes = linha.Split(',');

            string nome = partes[0];
            string telefone = partes[1];
            string email = partes[2];

            Console.WriteLine($"\nNome: {nome} | Telefone: {telefone} | Email: {email}");
        }
    }
}