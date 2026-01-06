//TRY | CATCH | FINALLY

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Tratamento de Erros!");
        Console.Write($"Digite um numero: ");
        string? resposta = Console.ReadLine();

        try
        {
            int numero = int.Parse(resposta);

            Console.WriteLine($"Numero convertido com sucesso!");
            Console.WriteLine($"Numero digitado foi : {numero}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ocorreu um erro com a conversão!");
            Console.WriteLine($"Mensagem do erro: {ex.Message}!");
        }
        catch (Exception)
        {
            Console.WriteLine($"Não conseguimos identificar a causa do erro!");
            Console.WriteLine($"Por favor, verifique sua resposta e tente novamente!");
        }
        finally
        {
            Console.WriteLine($"Obrigado pela atenção! Tenha um otimo dia");
        }
    }
}