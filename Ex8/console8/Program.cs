using System;

namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<IVeiculo> veiculos = new List<IVeiculo>()
        {
            new Carro(new MotorEletrico()),
            new Carro(new MotorAVapor()),
            new Moto(new MotorEletrico()),
            new Moto(new MotorAVapor()),
        };

        foreach (var veiculo in veiculos)
        {
            veiculo.Acelerar();
            veiculo.Parar();
            Console.WriteLine();
        }
    }
}