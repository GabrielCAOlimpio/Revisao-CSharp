using System;

namespace Program;

public class Aluno : IPessoa
{
    private string nome = string.Empty;
    private int idade;
    private string curso = string.Empty;
    
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
        get => idade < 0 ? 0 : idade;
        set
        {
            if (value >= 0)
                idade = value;
        }
    }
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
    {
        Nome = nome;
        Idade = idade;
        Curso = curso;
    }
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e estou matriculado no curso de {Curso}.");
    }
}
public class Gato : IAnimal
{
    private string nome = string.Empty;
    private string especie = "Gato";
    
    public string Nome
    {
        get => string.IsNullOrWhiteSpace(nome) ? "Nome não informado" : nome;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nome = value;
        }
    }
    public string Especie
    {
        get => especie;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                especie = value;
        }
    }
    public Gato(string nome)
    {
        Nome = nome;
    }
    public void FazerSom()
    {
        Console.WriteLine($"{Nome} diz: Miau!");
    }
}
public class Cachorro : IAnimal
{
    private string nome = string.Empty;
    private string especie = "Cachorro";
    
    public string Nome
    {
        get => string.IsNullOrWhiteSpace(nome) ? "Nome não informado" : nome;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nome = value;
        }
    }
    public string Especie
    {
        get => especie;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                especie = value;
        }
    }
    public Cachorro(string nome)
    {
        Nome = nome;
    }
    public void FazerSom()
    {
        Console.WriteLine($"{Nome} diz: Au Au!");
    }
}