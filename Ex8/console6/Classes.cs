using System;

namespace Program;

public abstract class Animal
{
    private string name = string.Empty;

    public string Name
    {
        get => string.IsNullOrWhiteSpace(name) ? "Unnamed" : name;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
        }
    }

    public Animal(string name)
    {
        Name = name;
    }
    public abstract void MakeSound();
    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name) {}

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Au! Au! Au!");
    }
}
public class Cat : Animal
{
    public Cat(string name) : base(name) {}

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow! Meow! Meow!");
    }
}
public class Cow : Animal
{
    public Cow(string name) : base(name) {}

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Moo! Moo! Moo!");
    }
}