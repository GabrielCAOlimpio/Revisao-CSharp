using System;

namespace Program;

public interface IMotor
{
    void Ligar();
    void Desligar();
}
public interface IVeiculo
{
    void Acelerar();
    void Parar();
}
