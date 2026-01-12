//QUEUE EM C# 

using System;

public class Program
{
    public static void Main()
    {
        Queue<string> fila = new(); // Cria uma fila de strings
        fila.Enqueue("Elemento 1"); // Adiciona elementos à fila (sempre no final)
        fila.Enqueue("Elemento 2");
        fila.Enqueue("Elemento 3");
        Console.WriteLine($"Elementos na fila: {string.Join(", ", fila)}");
        Console.WriteLine();

        //Em uma queue o primeiro elemento a entrar é o primeiro a sair (FIFO - First In, First Out)
        string proximoElemento = fila.Peek(); //Retorna o proximo elemento sem removê-lo
        Console.WriteLine($"Próximo elemento a ser removido: {proximoElemento}");
        Console.WriteLine();

        //Remove o primeiro elemento da fila (FIFO)
        string atendido = fila.Dequeue();
        Console.WriteLine($"Elemento removido: {atendido}");
        Console.WriteLine($"Elementos restantes na fila: {string.Join(", ", fila)}");
    }
}