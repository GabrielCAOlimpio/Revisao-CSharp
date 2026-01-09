//ABSTRACT CLASS
//Classe Abstrata
/*
    Uma classe abstrata é uma classe que não pode ser instanciada diretamente.
    Ela pode conter métodos abstratos (sem implementação) e métodos concretos (com implementação).
    Classes derivadas devem implementar os métodos abstratos da classe base.
    Uma classe abstrata não pode ser instanciada diretamente, ou seja, você não pode criar um objeto dela.
*/

using System;

namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog("Loki"),
            new Cat("Fumaça"),
            new Cow("Renata")
        };


        foreach (var animal in animals)
        {
            animal.MakeSound(); //An Abstract method is called
            animal.Sleep(); //A Concrete method is called
        }
    }
}