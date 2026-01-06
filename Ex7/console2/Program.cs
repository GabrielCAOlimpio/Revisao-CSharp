//OUT AND REF
//Out e ref

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Welcome to Brazil!");
        string nome = askYourName();
        Console.WriteLine($"Nice to meet you, {nome}!");
        Console.WriteLine($"I'm going to change your name with another method....");
        changeYourName(ref nome);
        Console.WriteLine($"Your name now is {nome}!");
        Console.WriteLine($"===========================================================");
        Console.WriteLine($"Another magic, I'm going to create a var with a void method...");
        createYourAge(out int age); //Here's I created a var without a global var
        Console.WriteLine($"Now your age is {age}");




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
        static void changeYourName(ref string oldName)
        {
            oldName = $"Gold {oldName}";
        }
        static void createYourAge(out int age)
        {
            age = 18;
        }
    
    }
}