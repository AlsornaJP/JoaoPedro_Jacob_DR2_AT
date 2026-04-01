namespace Exercicio9;

public class Estoque
{
    public Estoque()
    {
        ListaProdutos = new List<Produto>();
    }
    private List<Produto> ListaProdutos { get; }

    public void AdicionarProduto(Produto produto)
    {
        if (ListaProdutos.Count == 5)
        {
            Console.WriteLine("\nO limite de 5 itens foi alcançado");
            return;
        }
        
        bool jaExiste = ListaProdutos.Any(p => p.GetNome().ToLower().Equals(produto.GetNome().ToLower()));
        if(jaExiste)
        {
            Console.WriteLine("\nProduto já está no estoque");
            return;
        }
        
        ListaProdutos.Add(produto);
    }

    public void ListarProdutos()
    {
        string path = "estoque.txt";
        
        if (!File.Exists(path))
        {
            File.Create(path).Close();
            Console.WriteLine("Nenhum produto cadastrado");
            return;
        }

        var linhas = File.ReadAllLines(path);
        
        if (linhas.Length == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado");
            return;
        }

        foreach (var linha in linhas)
        {
            var partes = linha.Split(',');

            string nome = partes[0];
            int qtd = int.Parse(partes[1]);
            double preco = double.Parse(partes[2]);

            Console.WriteLine($"Produto: {nome} | Quantidade: {qtd} | Preço: R$ {preco}");
        }
    }
}
