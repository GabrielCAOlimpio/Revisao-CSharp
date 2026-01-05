//FOREACH
class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>(){1,2,3,4,5,6,7,8,9,10};

        Console.Write($"Contagem com FOREACH: ");
        foreach (int n in numeros)
        {
            Console.Write($"{n} ");   
        }
        
    }
}