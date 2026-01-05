//CONVERSÃO DE DADOS
//DATA CONVERSION

class Program
{
    static void Main ( string[] args)
    {
        Console.WriteLine($"Hello! Nice to meet you.");
        Console.Write($"What's your name: ");

        string? nome = Console.ReadLine();

        if (nome != null && !nome.IsWhiteSpace())
        {
            Console.WriteLine($"Nice to meet you {nome}");
            Console.Write($"How old are you: ");
            string? entrada = Console.ReadLine();
            bool resultado = int.TryParse(entrada, out int idade);

            if (resultado)
            {
                Console.WriteLine(idade >= 18 ? "You are an adult" : "You are a kid");
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand your age.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, I didn't understand your name.");
        }
        
    }
}