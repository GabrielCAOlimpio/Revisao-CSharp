using System;

namespace Program;

class User
{
    private string name = string.Empty;
    private int age;

    public string Nome
    {
        get => string.IsNullOrWhiteSpace(name) ? "Unknown" : name;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }

    public User(string name)
    {
        Nome = name;
    }
    public User(string name, int age) : this(name)
    {
        Age = age;
    }

    public void ShowInfo() //This is an instance method
    {
        Console.WriteLine($"Name: {Nome}, Age: {Age}");
    }
    public static void Greeting() //This is a static method
    {
        Console.WriteLine("Hello, welcome to our application!");
    }
}