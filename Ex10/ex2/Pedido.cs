namespace Exercicio2.Models;

public class Pedido
{
    public decimal Valor { get; set; }


    public Pedido(decimal valor)
    {
        Valor = valor;
    }

}