using System;

namespace Program;

public interface IPessoa
{
    string Nome { get; set; }
    int Idade { get; set; }

    void Apresentar();  
}
public interface IAnimal
{
    string Nome { get; set; }
    string Especie { get; set; }

    void FazerSom();
}