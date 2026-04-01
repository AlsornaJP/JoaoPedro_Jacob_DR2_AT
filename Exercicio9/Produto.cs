namespace Exercicio9;

public class Produto
{
    public Produto(string nome, int qtd, double preco)
    {
        Nome = nome;
        Qtd = qtd;
        Preco = preco;
    }

    private string Nome
    {
        get;
        set => field = (!string.IsNullOrEmpty(value))
            ? value
            : throw new ArgumentOutOfRangeException(nameof(value), "Nome inválido");
    }

    private int Qtd
    {
        get;
        set => field = (value >= 0)
            ? value
            : throw new ArgumentOutOfRangeException(nameof(value), "Quantidade não pode ser negativa");
    }

    private double Preco
    {
        get;
        set => field = (value >= 0)
            ? value
            : throw new ArgumentOutOfRangeException(nameof(value), "Preço não pode ser negativo");
    }

    public string GetNome()
    {
        return Nome;
    }
    public int GetQtd()
    {
        return Qtd;
    }
    public double GetPreco()
    {
        return Preco;
    }
    
    public string FormatoCsv()
    {
        return $"{Nome}, {Qtd}, {Preco}";
    }
}