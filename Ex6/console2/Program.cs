//While and Do.. While

class Program
{
    static void Main(string[] args)
    {
        int i = 1;

        Console.Write($"Contagem com While: ");
        while (i <= 10)
        {
            Console.Write($"{i} ");
            i +=1;
        }
        Console.WriteLine($"");

        do
        {
            Console.WriteLine($"O DO.. WHILE EXECUTA PELA MENOS 1 VEZ, INDEPENDENTE DA CONDIÇÃO");
        }
        while(i < 10);
    }
}