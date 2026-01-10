using System;
namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Aluno(),
            new Empresario(),
            new Funcionario(),
            new Pessoa()
        };

        foreach (var pessoa in pessoas)
        {
            pessoa.Apresentar();
        }
    }
}
