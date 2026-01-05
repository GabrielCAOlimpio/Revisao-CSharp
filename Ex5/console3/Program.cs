//SWITCH COM CONDIÇÃO
//SWITCH WITH CONDITION


class Program
{
    static void Main (string[] args)
    {
        int idade = 11;

        switch(idade)
        {
            case >= 18:
                Console.WriteLine($"Adulto");
                break;
            case > 12:
                Console.WriteLine($"Adolecente");
                break;
            case < 12 and  >= 0:
                Console.WriteLine($"Criança");
                break;
        }

        //Modern Switch
        string status = idade switch
        {
            >= 18 => "Adulto",
            > 12 => "Adolecente",
            < 12 and >= 0 => "Criança"
        };
        Console.WriteLine($"Switch Moderno: {status}");
    }
}