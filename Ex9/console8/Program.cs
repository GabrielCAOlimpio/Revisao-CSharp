//Jagged Arrays
//Arrays of arrays, where each "row" can have a different length.
//Arrays pt.3

using System;
public class Program
{
    public static void Main(string[] args)
    {
        //My first jagged array
        int[][] numeros = new int[][]
        {
            new int[] {1,2,3},
            new int[] {4,5},
            new int[] {6,7,8,9}
        };
        //Accessing elements
        Console.WriteLine($"My first jagged : {string.Join("," , numeros[0])}");
        Console.WriteLine($"My second jagged : {string.Join("," , numeros[1])}");
        Console.WriteLine($"My third jagged : {string.Join("," , numeros[2])}");
        Console.WriteLine();

        int numberFour = numeros[1][0];
        Console.WriteLine($"The first element of the second jagged array is: {numberFour}");

        string[][] jaggedStrings = [
            ["apple", "banana", "cherry"] ,
            ["dog", "elephant"] ,
            ["fish", "goat", "horse", "iguana"]
        ];
        Console.WriteLine($"The first element of the first jagged string array is: {jaggedStrings[0][0]}");
        Console.WriteLine($"My jagged string array (0,3): {string.Join(" | " , jaggedStrings[0])}");
        Console.WriteLine($"My jagged string array (1,2): {string.Join(" | " , jaggedStrings[1])}");
        Console.WriteLine($"My jagged string array (2,4): {string.Join(" | " , jaggedStrings[2])}");
        
    }
}

/*
    Jagged Arrays are arrays that contain other arrays as their elements.
    Each element of a jagged array can have a different length, allowing for more flexibility in

    Matriz Arrays where all rows must have the same length. size.
    They are useful when dealing with data that has varying lengths, such as lists of items or records with different numbers of fields.

    Simple Array are fixed-size collections of elements of the same type, while jagged arrays are arrays of arrays, allowing for more complex and flexible data structures.
*/