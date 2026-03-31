namespace Exercicio6;

class Program
{
    static void Main(string[] args)
    {
        Aluno joao = new Aluno("João Pedro", "1", "Análise de sistemas", 8.5);
        Aluno juliana = new Aluno("Juliana", "2", "Engenharia de software", 6);
        
        joao.ExibirInfo();
        juliana.ExibirInfo();
        joao.VerificarAprovacao();
        juliana.VerificarAprovacao();
    }
}