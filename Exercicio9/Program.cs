namespace Exercicio9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Controle de estoque");
        string path = "estoque.txt";
        Estoque estoque = new Estoque();
        bool rodando = true;
        
        while (rodando)
        { 
            Console.WriteLine("""
                            
                            O que deseja fazer?
                            1) Adicionar produto (máx. 5)
                            2) Listar produtos
                            3) Sair
                            
                            """);
            
            if(!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Entrada inválida");
            }
            
            switch (opcao)
            {
                case 1 :
                    try
                    {
                        Console.WriteLine("\nInsira o nome do produto:");
                        string? nome = Console.ReadLine();
                        
                        Console.WriteLine("\nInsira a quantidade do produto:");
                        if (!int.TryParse(Console.ReadLine(), out int qtd))
                        {
                            throw new ArgumentOutOfRangeException(nameof(qtd), "Valor inválido");
                        }
                        
                        Console.WriteLine("\nInsira o preço do produto:");
                        if (!double.TryParse(Console.ReadLine(), out double preco))
                        {
                            throw new ArgumentOutOfRangeException(nameof(preco), "Valor inválido");
                        }
        
                        Produto produto = new Produto(nome, qtd, preco);
                        estoque.AdicionarProduto(produto);
        
                        if (!File.Exists(path))
                        {
                            File.Create(path).Close();
                        }
                        using (StreamWriter sw = new StreamWriter(path, true))
                        {
                            sw.WriteLine(produto.FormatoCsv());
                        }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    } 
                    break;
                
                case 2: 
                    estoque.ListarProdutos();
                    break;
                
                case 3:
                    Console.WriteLine("\nFechando programa");
                    rodando = false;
                    break;
                
                default:
                    Console.WriteLine("\nEscolha uma das 3 opções disponíveis");
                    break;
            }
        }
       
    }
}