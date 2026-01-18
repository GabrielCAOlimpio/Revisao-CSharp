using System;

namespace Exercicio3.Models;

public class Usuario
{
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set;}

    public Usuario(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

}