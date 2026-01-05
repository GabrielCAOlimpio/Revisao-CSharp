//Incremento e Decremento
//Operador Ternario

//Increment and Decrement
// Ternary Operator
class Program
{
    static void Main (string[] args)
    {
        int a = 10;
        //int b = a++; //A + 1 -> Aqui voce atribui e depois incrementa ent fica 10
        int b2 = ++a; //1 + A -> Aqui voce incrementa e depois atribui ent fica 11
        //int c = a--; //A - 1 -> Aqui voce atribui e depois decrementa ent fica 11
        int c2 = --a; // Aqui voce decrementa e depois atribui o valor ent fica 10

        Console.WriteLine(a);
        Console.WriteLine(b2);
        Console.WriteLine(c2);
    }
}