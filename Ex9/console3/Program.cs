//HASHSET IN C#;
//HASHSET EM C#;

public class Program
{
    public static void Main(string[] args)
    {
        HashSet<int> numbers = [1,2,3,4,5]; //A moderna sintaxe de inicialização de HashSet em C# usa colchetes.
        
        //Adicionando elementos
        numbers.Add(6);
        numbers.Add(7);
        Console.WriteLine($"Numeros no Hashset : {string.Join(",",numbers)}");

        bool tryToAdd = numbers.Add(3); //Tentar adicionar um elemento duplicado
        //No hashset, elementos duplicados não são permitidos.
        Console.WriteLine($"Tentativa de adicionar 3 novamente: {(tryToAdd ? "Sucesso" : "Falha - Duplicado")}");

        //Removendo elementos
        numbers.Remove(4);
        Console.WriteLine($"Numeros após remover 4: {string.Join(",",numbers)}");

        //Verificando a existência de um elemento
        bool containsFive = numbers.Contains(5); //É muito mais rapido do que em uma lista.
        Console.WriteLine($"Hashset contém 5: {(containsFive ? "Sim" : "Não")}");
    }
}