namespace Exercicio6;

public class Aluno
{
    public Aluno(string nome, string matricula, string curso, double media)
    {
        Nome = nome;
        Matricula = matricula;
        Curso = curso;
        Media = media;
    }

    private string Nome { get; set; }
    private string Matricula { get; set; }
    private string Curso { get; set; }
    private double Media { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"""
                          ----------
                          Nome: {Nome}
                          Matrícula: {Matricula}
                          Curso: {Curso}
                          Média do aluno: {Media}
                          ----------
                          """);
    }

    public void VerificarAprovacao()
    {
        Console.WriteLine(Media >= 7 ? "Aprovado" : "Reprovado");
    }
}