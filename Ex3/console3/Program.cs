//Operadores de Comparação
//Condicional Operator

//Operadores Logicos
//Logic Operator

class Program
{
    static void Main (string[] args)
    {
        int x = 10;
        int y = 5;
        bool maior = x > y; //true 
        bool menor = x < y; //false
        bool igual = x == y; //false
        bool diferente = x != y; //true
        bool maiorIgual = x >= y; //true
        bool menorIgual = x <= y; //false

        bool and = x > y && x > 15; // False -> ( True && FALSE ) = False
        bool or = x > y || x > 15; //TRUE -> (True || False ) = True
        bool not = ! (x > y); //False -> !(True) = False

        Console.WriteLine(maior);
        Console.WriteLine(menor);
        Console.WriteLine(igual);
        Console.WriteLine(diferente);
        Console.WriteLine(maiorIgual);
        Console.WriteLine(menorIgual);
        Console.WriteLine(and);
        Console.WriteLine(or);
        Console.WriteLine(not);
    }
}