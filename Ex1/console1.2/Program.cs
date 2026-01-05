class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nome: " + args[0]);
        Altura();
        Console.WriteLine("Idade: " + args[1]);


        void Altura()
        {
            Console.WriteLine("Altura: " + args[2]);
        }
    }
    
}