//Matrizes Arrays C#
//Arrays Multidimensionais
//Arrays pt.2
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //My fist matriz
        string[,] myFirstMatriz =
        {
            {"Apple", "Banana", "Cherry"},
            {"Date", "Elderberry", "Fig"},
            {"Grape", "Honeydew", "Kiwi"}
        };
        //This is a 3x3 matriz
        //I can create using : string[,] myFirstMatriz = new string[3,3]; too

        Console.WriteLine($"This is a 2D matriz (3x3):");
        for (int i = 0; i < myFirstMatriz.GetLength(0); i++)
        {
            for (int j = 0; j < myFirstMatriz.GetLength(1); j++)
            {
                Console.Write($"[{myFirstMatriz[i, j]}] ");
            }
            Console.WriteLine();
        }
        //If you want to access a specific element, you can do it using its indexes
        Console.WriteLine();
        var randowElement = myFirstMatriz[2,2]; //Accessing the element in the 3rd row and 3nd column (Kiwi)
        Console.WriteLine($"The element in the 3rd row and 3nd column is: {randowElement}");

        Console.WriteLine($"I can create many dimensions in a matriz:");
        //Creating a 3D matriz
        int[,,] my3dMatriz =
        {
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            },
            {
                {10, 11, 12},
                {13, 14, 15},
                {16, 17, 18}
            },
            {
                {19, 20, 21},
                {22, 23, 24},
                {25, 26, 27}
            }
        };

        /*Visualization of the 3D matriz:
        Layer 1:           Layer 2:           Layer 3:
        1  2  3          10 11 12            19 20 21
        4  5  6          13 14 15            22 23 24
        7  8  9          16 17 18            25 26 27
        */
        Console.WriteLine($"This is a 3x3x3 matriz:");
        Console.WriteLine($"It's possible 27 elements in this 3D matriz:");
        for (int i = 0; i < my3dMatriz.GetLength(0); i++)
        {
            for (int j = 0; j < my3dMatriz.GetLength(1); j++)
            {
                for (int k = 0; k < my3dMatriz.GetLength(2); k++)
                {
                    Console.Write($"[{my3dMatriz[i, j, k]}] ");
                }
                Console.WriteLine();
            }
        }
    }
}