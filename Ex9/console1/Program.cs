//List example in C#
//Listas em C#

using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        numbers.Add(1); //Adding an element
        numbers.AddRange(new List<int> { 2, 3, 4 }); //Adding multiple elements
        Console.WriteLine($"My List: [{string.Join(",",numbers)}]");
        
        numbers.Insert(3, 5); //Inserting an element at index 3 [1,2,3,5,4]
        Console.WriteLine($"After Insertion at index 3: {string.Join(",", numbers)}");

        numbers.Remove(2); //Removing element with value 2 [1,3,5,4]
        Console.WriteLine($"After Removing 2: {string.Join(",", numbers)}");

        numbers.RemoveAt(numbers.Count - 1); //Removing last element [1,3,5]
        Console.WriteLine($"After Removing last element: {string.Join(",", numbers)}");

        bool containsASpecificValue = numbers.Contains(3); //Checking if list contains value 3
        Console.WriteLine($"List contains 3: {containsASpecificValue}");

    }
}