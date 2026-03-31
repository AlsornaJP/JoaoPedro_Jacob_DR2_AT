namespace Exercicio_8;

public class Gerente(string nome, string cargo, double salarioBase) : Funcionario(nome, cargo, salarioBase)
{
    private double _bonus = 1.20;
    
    public override double CalcularSalario()
    {
        return SalarioBase * _bonus;
    }
}