using System;
using Exercicio3.Models;

namespace Exercicio3.Program;

public class Program
{
    public static void Main(string[] args)
    {
        IEnumerable<object> lista =
        [
            "Exercicio 3 - Criando uma classe Usuario",
            "Criado por: Gariel Olimpio", 
            new Usuario("Gariel Olimpio", 25),
            new Usuario("Maria Silva", 30),
            new Usuario("João Souza", 12),
            12345,
            43.67
        ];

        var usuarios = lista
            .Where(item => item is Usuario)
            .Cast<Usuario>()
            .ToList();

        var usuariosMaioresDeIdade = usuarios.Select(
                        u => u switch
                        {
                            { Idade: >= 18} => u.Nome,
                            _ => "Menor de idade"
                        }).ToList();

        foreach (var item in usuariosMaioresDeIdade)
        {
            Console.WriteLine(item);
        }
        

    }
}