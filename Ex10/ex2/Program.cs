using System;
using Exercicio2.Models;

namespace Exercicio2.Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<object> dados = 
        [
            new Pedido(90.0m),
            new Pedido(250.5m),
            new Pedido(745.25m),
            "ABc123",
            "XYZ789",
            123,
            12.45
        ];

        var pedidos = dados.
            Where(d => d is Pedido)
            .Cast<Pedido>()
            .ToList();

        var pedidosComStatus = pedidos
            .Select(p => new
            {
            p.Valor,
            Status = p switch
            {
                { Valor: < 100.0m } => "Pedido barato",
                { Valor: >= 100.0m and <= 500.0m } => "Pedido normal",
                _ => "Pedido caro"
            }
            })
            .ToList();

        foreach (var pedido in pedidosComStatus)
        {
            Console.WriteLine($"Valor: {pedido.Valor}, Status: {pedido.Status}");
        }
        
    }
}