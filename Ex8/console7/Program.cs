//Interfaces

/*
    Uma Interface em C# é um contrato que define um conjunto de métodos e propriedades que uma classe deve implementar.
    Diferente de uma classe abstrata, uma interface não pode conter implementação de métodos, apenas
    suas assinaturas. As interfaces são usadas para definir comportamentos comuns entre classes não relacionadas,
    promovendo a flexibilidade e a reutilização de código.
*/


using System;

namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<IPessoa> pessoas = new List<IPessoa>()
        {
            new Aluno("João", 20, "Engenharia"),
            new Aluno("Maria", 45, "Matemática"),
            new Aluno("Ana", 22, "Medicina"),
            new Aluno("Carlos", 50, "História")
        };
        List<IAnimal> animais = new List<IAnimal>()
        {
            new Gato("Mingau"),
            new Gato("Tom"),
            new Gato("Garfield"),
            new Cachorro("Rex"),
            new Cachorro("Bolt"),
            new Cachorro("Pluto")
        };

        Console.WriteLine($"Total de pessoas: {pessoas.Count}");
        foreach (var pessoa in pessoas)
        {
            pessoa.Apresentar();
        }
        Console.WriteLine();
        Console.WriteLine($"Total de animais: {animais.Count}");
        foreach (var animal in animais)
        {
            animal.FazerSom();
        }
    }
}