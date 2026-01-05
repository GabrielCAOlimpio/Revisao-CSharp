//OLD SWITCH AND MODERN SWITCH
//Switch antigo e Switch Moderno

class Program
{
    static void Main(string[] args)
    {
        int opc = 6;

        //OLD
        switch(opc)
        {
            case opc:
                Console.WriteLine($"Cadastrar: ");
                break;
            case 2:
                Console.WriteLine($"Editar: ");
                break;
            case 3:
                Console.WriteLine($"Inserir: ");
                break;
            case 4:
                Console.WriteLine($"Deletar: ");
                break;
            default:
                Console.WriteLine($"Opção Invalida!");
                break;
        }

        //Modern
        string result = opc switch
        {
            1 => "Cadastrar: ",
            2 => "Editar: ",
            3 => "Inserir: ",
            4 => "Deletar: ",
            _ => "Opção Invalida! "
        };

        Console.WriteLine($"Switch Moderno: {result}");
    }
}