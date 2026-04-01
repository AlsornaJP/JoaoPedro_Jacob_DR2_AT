using System.Text.RegularExpressions;

namespace Exercicios11_12;

public class Contato
{
    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }

    private string Nome
    {
        get;
        set => field = !string.IsNullOrEmpty(value)
            ? value
            : throw new ArgumentOutOfRangeException(nameof(value), "Nome inválido");
    }

    private string Telefone
    {
        get;
        set => field = !string.IsNullOrEmpty(value) || Regex.IsMatch(value, @"[0-9]{11}")
            ? value
            : throw new ArgumentOutOfRangeException(nameof(value), "Telefone inválido. Insira o numero com DDD e tudo junto");
    }

    private string Email
    {
        get;
        set => field = !string.IsNullOrEmpty(value) || !value.EndsWith("@email.com")
            ? value
            : throw new ArgumentOutOfRangeException(nameof(value), "Endereço de email inválido");
    }
    
    
    public string FormatoCsv()
    {
        return $"{Nome}, {Telefone}, {Email}";
    }
}