
using System;
using Exercicio1.Models;
namespace Exercicio1.Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<Object> lista = 
        [
            new Cliente("Ana", true),
            new Cliente("Bruno", false),
            new Funcionario("Carlos", "Gerente"),
            "BADCODE",
            12345
        ];

        var dados = lista.Select(item =>
            item switch
            {
               Cliente {IsVip: true} c => $"Cliente VIP: {c.Nome}",
               Cliente {IsVip: false} c => $"Cliente Comum: {c.Nome}",
               Funcionario f => $"Funcionário: {f.Nome}, Cargo: {f.Cargo}",
               _ => $"Tipo desconhecido : {item}"
            }
        ).ToList();

        foreach (var item in dados)
        {
            Console.WriteLine(item);
        }
    }
}