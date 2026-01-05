//ENTRADA E SAIDA
//Input and Output

class Program
{
    static void Main(string[] args)
    {
        //Output
        Console.WriteLine($"Hello, Nice to meet you"); //There is a line break
        Console.Write($"What's your name: "); //There is no a line break

        //Input
        string? nome = Console.ReadLine();

        //Output
        if (nome != null && !nome.IsWhiteSpace())
        {
            Console.WriteLine($"Good Morning, {nome}!");
        }
        else
        {
            Console.WriteLine($"Sorry, I didn't understand your name.");
        }
    }
}