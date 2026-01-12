//Dicionarios em C#
//Dictionary example in C#

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> ages = new()
        {
            ["Gabriel"] = 25,
            ["Ana"] = 30,
            ["Pedro"] = 20
        }; //A modern way to instantiate a Dictionary<string, int>
        //I can use : Dictionary<string, int> ages = new Dictionary<string, int>(); too
        
        //Adding an element
        ages["Maria"] = 28; //If the key already exists, it updates the value
        ages.Add("João", 22); //Another way to add an element

        foreach (var (key,value) in ages)
        {
            Console.WriteLine($"{key}: {value} years old");
        }
        Console.WriteLine();
        //Accessing an element
        Console.WriteLine($"Ana's age: {ages["Ana"]} years old");
        Console.WriteLine();
        //Removing an element
        ages.Remove("Pedro");
        Console.WriteLine("After removing Pedro:");
        foreach (var (key,value) in ages)
        {
            Console.WriteLine($"{key}: {value} years old");
        }
        Console.WriteLine();
        //Checking if a key exists
        bool hasGabriel = ages.ContainsKey("Gabriel");
        Console.WriteLine($"Dictionary contains Gabriel: {hasGabriel}");
    }
}