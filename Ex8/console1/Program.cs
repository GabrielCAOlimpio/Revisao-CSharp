using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Gabriel");
            Console.WriteLine($"Nome da pessoa: {pessoa.Nome}");
            Pessoa pessoa2 = new Pessoa("Ana", 25);
            Console.WriteLine($"Nome da pessoa: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
        }
    }
}