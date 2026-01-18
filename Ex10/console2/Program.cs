//Linq pt2 C#

using System;

public class Program
{
    public static void Main()
    {
        List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        bool EhPar = numeros.All(n => n % 2 == 0);
        bool temPar = numeros.Any(n => n % 2 == 0);

        Console.WriteLine($"Todos os números são pares? {EhPar}");
        Console.WriteLine($"Existe algum número par? {temPar}");
        Console.WriteLine();

        int coutPar = numeros.Count(n => n % 2 == 0);
        Console.WriteLine($"Quantidade de números pares: {coutPar}");

        int nBiggerNine = numeros.Single(n => n > 9);
        Console.WriteLine($"O unico Número maior que 9: {nBiggerNine}");
        Console.WriteLine();

        try
        {
            int nBiggerFive = numeros.Single(n => n > 5);
            Console.WriteLine($"O unico Número maior que 5: {nBiggerFive}");
        }
        catch
        {
            Console.WriteLine($"Existe mais de um número maior que 5.");
        }
        Console.WriteLine();

        var lessNumbers = numeros.OrderBy(n => n).Take(3);
        Console.WriteLine($"Os três menores números: {string.Join(", ", lessNumbers)}");

        var middleNumbers = numeros.OrderBy(n => n).Skip(3).Take(3);
        Console.WriteLine($"Três números do meio: {string.Join(", ", middleNumbers)}");

        var biggerNumbers = numeros.OrderByDescending(n => n).Take(3);
        Console.WriteLine($"Os três maiores números: {string.Join(", ", biggerNumbers)}");

        var uniqueNumber = numeros.OrderByDescending(n => n).Skip(3).Take(1);
        Console.WriteLine($"O numero que não é nem dos três maiores nem dos três menores: {string.Join(", ", uniqueNumber)}");

        Console.WriteLine();
        var somaTotal = numeros.Sum();
        Console.WriteLine($"A soma de todos os números: {somaTotal}");

        var somaPares = numeros.Sum(x => x % 2 == 0 ? x : 0 );
        Console.WriteLine($"A soma dos números pares: {somaPares}");

        var somaImpares = numeros.Sum(x => x % 2 != 0 ? x : 0 );
        Console.WriteLine($"A soma dos números ímpares: {somaImpares}");

        Console.WriteLine();
        var maior = numeros.Max();
        var menor = numeros.Min();
        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");

        Console.WriteLine();
        var media = numeros.Average();
        Console.WriteLine($"A média dos números é: {media}");

        
    }
}
