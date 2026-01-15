//Linq #3

using System;
namespace Program;

public class Program
{
    public static void Main()
    {
        List<Categoria> categorias = new()
        {
            new(1, "Eletrônicos"),
            new(2, "Móveis"),
            new(3, "Acessórios")
        };
        List<Produto> produtos = new()
        {
            new(1, "Laptop", 1500.00m, 1),
            new(2, "Smartphone", 800.00m, 1),
            new(3, "Cadeira", 120.00m, 2),
            new(4, "Mesa", 300.00m, 2),
            new(5, "Fone de Ouvido", 150.00m, 1),
            new(6, "Notebook", 2000.00m, 1),
            new(7, "Estante", 400.00m, 2),
            new(8, "Monitor", 450.00m, 1),
            new(9, "Teclado", 200.00m, 1),
            new(10, "Mouse", 80.00m, 1),
            new(11, "Webcam", 250.00m, 1),
            new(12, "Mousepad", 30.00m, 1),
            new(13, "Suporte para Monitor", 60.00m, 2),
            new(14, "Armário", 500.00m, 2),
            new(15, "Prateleira", 150.00m, 2),
            new(16, "Luminária", 120.00m, 1),
            new(17, "Hub USB", 90.00m, 1),
            new(18, "Cabo HDMI", 45.00m, 1),
            new(19, "Carregador", 60.00m, 1),
            new(20, "Bateria Externa", 180.00m, 1),
            new(21, "Adaptador de Tomada", 40.00m, 1),
            new(22, "Capa para Notebook", 70.00m, 3),
            new(23, "Mochila", 150.00m, 3),
            new(24, "Organizador de Cabos", 50.00m, 3),
            new(25, "Protetor de Tela", 35.00m, 3),
            new(26, "Stand para Smartphone", 45.00m, 3),
            new(27, "Espelho", 80.00m, 2),
            new(28, "Rack de Parede", 200.00m, 2)
        };
        
        
        var pedidos = from p in produtos
                    join c in categorias
                    on p.CategoriaId equals c.CategoriaId
                    select new
                    {
                        ProdutoNome = p.Nome,
                        CategoriaNome = c.Nome,
                        Preco = p.Preco
                    } into pc/*produto-categoria*/
                    group pc by pc.CategoriaNome
                      ;
        
        //Another way to do the same using method syntax
        /*var pedidos = produtos.Join(
            categorias,
            p => p.CategoriaId,
            c => c.CategoriaId,
            (p, c) => new
            {
                ProdutoNome = p.Nome,
                CategoriaNome = c.Nome,
                Preco = p.Preco
            }).GroupBy(x => x.CategoriaNome);
        */
            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Categoria: {pedido.Key}");
                foreach (var item in pedido)
                {
                    Console.WriteLine($" - Produto: {item.ProdutoNome}, Preço: {item.Preco:C}");
                }
                Console.WriteLine();            
            }
                    
    }
}