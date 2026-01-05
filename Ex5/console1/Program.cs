//IF AND ELSE
//IF E ELSE

class Program
{
    static void Main(string[] args)
    {
        int idade = 12;

        if (idade >= 18)
        {
            Console.WriteLine($"Você tem {idade} anos é um adulto!");
        }
        else if (idade > 12)
        {
            Console.WriteLine($"Você tem {idade} anos, é um adolecente!");
        }
        else
        {
            Console.WriteLine($"Você tem {idade} anos, é uma criança");
        }
    }
}