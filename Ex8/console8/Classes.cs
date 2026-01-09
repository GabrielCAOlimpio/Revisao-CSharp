using System;

namespace Program;

public class MotorEletrico : IMotor
{
    public void Ligar()
    {
        Console.WriteLine("Motor elétrico ligado.");
    }

    public void Desligar()
    {
        Console.WriteLine("Motor elétrico desligado.");
    }
}
public class MotorAVapor : IMotor 
{
    public void Ligar()
    {
        Console.WriteLine("Motor a vapor ligado.");
    }

    public void Desligar()
    {
        Console.WriteLine("Motor a vapor desligado.");
    }
}
public class Carro : IVeiculo 
{
    private IMotor _motor; //Composição

    public Carro(IMotor motor)
    {
        _motor = motor; //Composição    
    }
    public void Acelerar()
    {
        _motor.Ligar(); //Composição    
        Console.WriteLine("Carro acelerando.");
    }

    public void Parar()
    {
        _motor.Desligar(); //Composição    
        Console.WriteLine("Carro parando.");
    }
}
public class Moto : IVeiculo 
{
    private IMotor _motor; //Composição    

    public Moto(IMotor motor)
    {
        _motor = motor; //Composição    
    }

    public void Acelerar()
    {
        _motor.Ligar(); //Composição    
        Console.WriteLine("Moto acelerando.");
    }
    public void Parar()
    {
        _motor.Desligar(); //Composição    
        Console.WriteLine("Moto parando.");
    }
    
}