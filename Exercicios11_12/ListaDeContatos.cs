namespace Exercicios11_12;

public static class ListaDeContatos
{
    public static void AdicionarContato(Contato contato)
    {
        string path = "contatos.txt";
        if (!File.Exists(path))
        {
            File.Create(path).Close();
        }
        using (StreamWriter sw = new StreamWriter(path, true))
        {
            sw.WriteLine(contato.FormatoCsv());
        }

        Console.WriteLine("\n Contato dicionado com sucesso!");
    }

    public static void ListarContatos()
    {
        string path = "contatos.txt";
        
        if (!File.Exists(path))
        {
            File.Create(path).Close();
            Console.WriteLine("\nNenhum contato registrado");
            return;
        }

        var linhas = File.ReadAllLines(path);
        
        if (linhas.Length == 0)
        {
            Console.WriteLine("\nNenhum contato registrado");
            return;
        }

        Console.WriteLine("=== Contatos registrados ===");
        foreach (var linha in linhas)
        {
            var partes = linha.Split(',');

            string nome = partes[0];
            string telefone = partes[1];
            string email = partes[2];

            Console.WriteLine($"\nNome: {nome} | Telefone: {telefone} | Email: {email}");
        }
    }
}