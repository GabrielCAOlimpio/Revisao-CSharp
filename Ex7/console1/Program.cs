//Métodos / Funções
//Methods / Functions

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Welcome to Brazil");
        string nome = askYourName();
        Console.WriteLine($"Nice to meet you, {nome}!");
        showLines();
        int age = askYourAge();
        
        if (age >= 18)
        {
            Console.WriteLine($"You are {age} years old, You are an adult!");
        }
        else if (age >= 13)
        {
            Console.WriteLine($"You are {age} years old, You are a teenager!");
        }
        else
        {
            Console.WriteLine($"You are {age} years old, You are a kid!");
        }





        static string askYourName()
        {
            while (true)
            {
                Console.Write($"What's your name: ");
                string? nome = Console.ReadLine();

                if (nome == null || nome.IsWhiteSpace())
                {
                    Console.WriteLine($"I'm sorry, I didn't understand your name.");
                    Console.WriteLine($"Please, Enter a valid name!");
                }
                else
                {
                    return nome;
                }
            }
            
        }
        static void showLines()
        {
            Console.WriteLine("=================================================================");
        }
        static int askYourAge()
        {
            while (true)
            {
                Console.Write($"How old are you: ");
                string? entrada = Console.ReadLine();
                bool status = int.TryParse(entrada, out int idade);

                if (status)
                {
                    return idade;
                }
                else
                {
                    Console.WriteLine($"Please enter a valid age!");
                }
            }
            
        }
    }
}