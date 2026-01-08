namespace MinhaLib;

public class Uteis
{
    public static void Title(string texto)
    {
        Console.WriteLine();
        for (int i = 0; i < 100; i++)
        {
            Console.Write("=");
        }
        Console.WriteLine();
        Console.WriteLine(texto.ToUpper().PadLeft((50 + texto.Length / 2), ' '));
        for (int i = 0; i < 100; i++)
        {
            Console.Write("=");
        }
        Console.WriteLine();
    }
    public static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
    public static void Clear()
    {
        Console.Clear();
    }
    public static void Menu(string[] opções)
    {
        for (int i = 0; i < opções.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {opções[i]}");
        }
        Console.WriteLine("0 - Sair");
    }

    public static int LerInteiro(string n)
    {
        int valor;
        while (true)
        {
            Console.Write(n);
            if (int.TryParse(Console.ReadLine(), out valor))
            {
                return valor;
            }
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
    }
    public static string LerTexto(string texto)
    {
        Console.Write(texto);
        string mens = Console.ReadLine();

        while(string.IsNullOrWhiteSpace(mens))
        {
            Console.WriteLine($"Mensagem Invalida! Digite uma mensagem não nula e não vazia");
            mens = Console.ReadLine();      
        }


        return mens;
    }
}

