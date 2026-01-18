using System;
using Console5.Database;

namespace Console5.Program;

public class Program
{
    public static void Main(string[] args)
    {
        Db db = new Db();

        var produtos = db.Produtos.Select(
            c => new
            {
                c.Nome,
                c.Preco,
                Status = c switch
                {
                    { Preco: >= 1000 } => "Caro",
                    { Preco: >= 100 and < 1000 } => "Normal",
                    { Preco: < 100 } => "Barato",
                }, // Isso é um pattern matching com propriedades
                Categoria = c.Categoria.CategoriaNome
            }
        ).ToList();

        foreach (var produto in produtos)
        {
            Console.WriteLine(new string('=', 30));
            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Categoria: {produto.Categoria}");
            Console.WriteLine($"Preço: R$ {produto.Preco:F2}");
            Console.WriteLine($"Status: {produto.Status}");
            Console.WriteLine(new string('-', 30));
        }
    }
}