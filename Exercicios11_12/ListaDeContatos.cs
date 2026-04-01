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
        
        Console.WriteLine("""
                          === Escolha a forma que deseja visualizar os contatos ===
                          1) Texto puro
                          2) Tabela
                          3) Markdown
                          
                          """);
        if(!int.TryParse(Console.ReadLine(), out int opcao))
        {
            Console.WriteLine("Entrada inválida");
        }

        switch (opcao)
        {
            case 1:
                RawTextFormatter formatador1 = new RawTextFormatter();
                formatador1.ExibirLista(linhas);
                break;
            
            case 2:
                TableFormatter formatador2 = new TableFormatter();
                formatador2.ExibirLista(linhas);
                break;
            
            case 3:
                MarkdownFormatter formatador3 = new MarkdownFormatter();
                formatador3.ExibirLista(linhas);
                break;
        }
    }
}