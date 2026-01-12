using System;
namespace Program;

public abstract class Forma
{
    public abstract double CalcularArea();
}

public class Quadrado : Forma
{
    public double A {get; set;}
    public double B {get; set;}

    public Quadrado(double a, double b)
    {
        A = a;
        B = b;
    }
    public override double CalcularArea()
    {
        return A * B;
    }
}
public class Triangulo : Forma
{
    public double A {get; set;}
    public double B {get; set;}

    public Triangulo(double a, double b)
    {
        A = a;
        B = b;
    }
    public override double CalcularArea()
    {
        return (A * B) / 2;
    }
}
public class Circulo : Forma
{
    public double Raio {get; set;}

    public Circulo (double raio)
    {
        Raio = raio;
    }
    public override double CalcularArea()
    {
        return 3.14 * (Raio * Raio);
    }
}