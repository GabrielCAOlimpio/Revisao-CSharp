//Herança e Polimorfismo em C#
//Poliformism and Inheritance in C#

using System;

namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Aluno("Ana", 20, "Engenharia"),
            new Aluno("Bruno", 22, "Medicina"),
            new Aluno("Carlos", 21, "Direito"),
            new Pessoa("Lucas", 30),
            new Pessoa("Mariana", 28),
            new Pessoa("Pedro", 35)
        };
        foreach (var pessoa in pessoas)
        {
            pessoa.Apresentar(); // Same method, different behavior
            Console.WriteLine();
        }
    }
}

