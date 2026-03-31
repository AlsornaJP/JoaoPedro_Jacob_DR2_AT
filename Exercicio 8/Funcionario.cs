namespace Exercicio_8;

public class Funcionario
{
    public Funcionario(string nome, string cargo, double salarioBase)
    {
        Nome = nome;
        Cargo = cargo;
        SalarioBase = salarioBase;
    }

    protected string Nome { get; set; }
    protected string Cargo { get; set; }
    protected double SalarioBase { 
        get;
        set => field = (value > 0) ? value : throw new ArgumentOutOfRangeException(nameof(value), "Salário não pode ser negativo");
    }

    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
}