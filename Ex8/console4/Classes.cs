using System;

namespace Program;

public class Pessoa
{
    private string nome = string.Empty;
    private int idade;

    public string Nome
    {
        get => string.IsNullOrWhiteSpace(nome) ? "Nome não informado" : nome;

        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nome = value;
        }
    }
    public int Idade
    {
        get => idade;

        set
        {
            if (value >= 0 && value <= 120)
                idade = value;
        }
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

public class Aluno : Pessoa
{
    private string curso = string.Empty;    

    public string Curso
    {
        get => string.IsNullOrWhiteSpace(curso) ? "Curso não informado" : curso;

        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                curso = value;
        }
    }
    public Aluno(string nome, int idade, string curso) 
    :base(nome,idade)
    {
        Curso = curso;
    }

    public void ApresentarAluno()
    {
        Apresentar();
        Console.WriteLine($"Curso: {Curso}");
    }
}
