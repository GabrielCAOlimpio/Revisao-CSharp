using System;
namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        double a = 10;
        double b = 5;

        List<Forma> formas = new List<Forma>()
        {
            new Quadrado(a,b),
            new Circulo(a),
            new Triangulo(a,b)
        };

        Console.WriteLine($"LADOS DO QUADRADO : {a} e {b}\nÁREA DO QUADRADO: {formas[0].CalcularArea()}\n");
        Console.WriteLine($"MEDIDAS DO TRIANGULO : {a} e {b}\nÁREA DO TRIANGULO: {formas[2].CalcularArea()}\n");
        Console.WriteLine($"RAIO DO CIRCULO: {a}\nArea do Circulo: {formas[1].CalcularArea()}");
    }
}