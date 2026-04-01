namespace Exercicios11_12;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Lista de contatos");
        bool rodando = true;
        
        while (rodando)
        { 
            Console.WriteLine("""
                            
                            === Gerenciador de Contatos ===
                            1) Adicionar contato
                            2) Listar contatos
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
                        Console.WriteLine("\nInsira o nome do contato:");
                        string? nome = Console.ReadLine();
                        
                        Console.WriteLine("\nInsira o telefone:");
                        string? telefone = Console.ReadLine();
                        
                        Console.WriteLine("\nInsira o email:");
                        string? email = Console.ReadLine();
        
                        Contato contato = new Contato(nome, telefone, email);
                        ListaDeContatos.AdicionarContato(contato);
                        
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    } 
                    break;
                
                case 2: 
                    ListaDeContatos.ListarContatos();
                    break;
                
                case 3:
                    Console.WriteLine("\nFechando programa");
                    rodando = false;
                    break;
                
                default:
                    Console.WriteLine("\nEscolha uma das 3 opções disponíveis");
                    break;
            }
        }    }
}