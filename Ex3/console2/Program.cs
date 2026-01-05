//OPERADORES DE ATRIBUIÇÃO
//ATRIBUTION OPERATOR

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 3;

        a +=b; //Como se fosse A = A + B -> 10 + 3 = 13
        Console.WriteLine(a);

        a -=b; //Como se fosse A = A - B -> 13 - 3 = 10
        Console.WriteLine(a);

        a *= b; // Como se fosse A = A * B -> 10 * 3 = 30
        Console.WriteLine(a);

        a /= b; //Como se fosse A = A / B; -> 30 / 3 = 10
        Console.WriteLine(a);
    }
}