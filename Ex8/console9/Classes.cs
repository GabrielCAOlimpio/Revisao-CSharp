using System;
namespace Program;

public class Pessoa
{
    public virtual void Apresentar()
    {
        Console.WriteLine($"OLÁ SOU UMA PESSOA COMUM!");
    }
}
public class Aluno : Pessoa
{
    public override void Apresentar()
    {
        Console.WriteLine($"OLÁ SOU UM ESTUDANTE!");
    }
}
public class Funcionario : Pessoa
{
    public override void Apresentar()
    {
        Console.WriteLine($"OLÁ SOU UM TRABALHADOR!");
    }
}
public class Empresario : Pessoa
{
    public override void Apresentar()
    {
        Console.WriteLine($"OLÁ SOU UM EMPRESÁRIO!");
    }
}