//Stacks em C#
//Pilhas em C#

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Stack<string> pilha = new(["Elemento A", "Elemento B", "Elemento C"]); // Cria uma pilha de strings com elementos iniciais
        Console.WriteLine($"Elementos na pilha: {string.Join(", ", pilha)}");
        Console.WriteLine();

        //Em uma stack o último elemento a entrar é o primeiro a sair (LIFO - Last In, First Out)
        //Adiciona um novo elemento ao topo da pilha
        pilha.Push("Elemento D"); // Adiciona elementos à pilha (sempre no topo)
        Console.WriteLine($"Elementos na pilha após Push: {string.Join(", ", pilha)}");
        Console.WriteLine();
        
        //Retorna o elemento do topo sem removê-lo
        string topo = pilha.Peek();
        Console.WriteLine($"Elemento no topo da pilha (Peek): {topo}");

        //Remove o elemento do topo da pilha
        Console.WriteLine($"Elemento removido da pilha (Pop): {pilha.Pop()}");
        Console.WriteLine($"Elementos restantes na pilha: {string.Join(", ", pilha)}");
    }
}