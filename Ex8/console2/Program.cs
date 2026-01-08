using MinhaLib;
using System;
using System.Security.Cryptography;
namespace Program;


class Program
{
    public static void Main(string[] args)
    {
        List<Livro> livros = new List<Livro>()
        {
            new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954),
            new Livro("1984", "George Orwell", 1949),
            new Livro("Dom Casmurro", "Machado de Assis", 1899),
            new Livro("A Revolução dos Bichos", "George Orwell", 1945),
            new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943),
            new Livro("Cem Anos de Solidão", "Gabriel García Márquez", 1967),
            new Livro("Moby Dick", "Herman Melville", 1851),
            new Livro("Orgulho e Preconceito", "Jane Austen", 1813),
            new Livro("O Morro dos Ventos Uivantes", "Emily Brontë", 1847),
            new Livro("A Metamorfose", "Franz Kafka", 1915),
            new Livro("O Grande Gatsby", "F. Scott Fitzgerald", 1925),
            new Livro("Crime e Castigo", "Fiódor Dostoiévski", 1866),
            new Livro("A Montanha Mágica", "Thomas Mann", 1924),
            new Livro("O Processo", "Franz Kafka", 1925),
            new Livro("O Estrangeiro", "Albert Camus", 1942),
            new Livro("A Divina Comédia", "Dante Alighieri", 1320),
            new Livro("O Sol é Para Todos", "Harper Lee", 1960),
            new Livro("O Apanhador no Campo de Centeio", "J.D. Salinger", 1951),
            new Livro("Fahrenheit 451", "Ray Bradbury", 1953),
            new Livro("O Alquimista", "Paulo Coelho", 1988)
        };
        while (true)
        {
            Uteis.Title("BIBLIOTECA DE LIVROS");
            Console.WriteLine();
            Uteis.Menu(new string[] { "Adicionar Livro", "Listar Livros", "Remover Livro" });
            Console.Write("Escolha uma opção: ");
            int n = Uteis.LerInteiro("");

            if (n == 0)
            {
                Uteis.Title("Muito Obrigado! Tenha um ótimo dia!");
                break;
            }
            else if (n == 1)
            {
                Uteis.Title("ADICIONAR LIVRO");
                string titulo = Uteis.LerTexto("Digite o título do livro: ");
                string autor = Uteis.LerTexto("Digite o autor do livro: ");
                int ano = Uteis.LerInteiro("Digite o ano de publicação do livro (0 se desconhecido): ");
                Livro novoLivro = ano > 0 ? new Livro(titulo, autor, ano) : new Livro(titulo, autor);
                livros.Add(novoLivro);
                Console.WriteLine("Livro adicionado com sucesso!");
                Uteis.Pause();
                Uteis.Clear();
            }
            else if (n == 2)
            {
                Uteis.Title("LISTA DE LIVROS");
                if (livros.Count == 0)
                {
                    Console.WriteLine("Nenhum Livro Cadastrado.");
                }
                else
                {
                    Console.WriteLine("{0,-40} {1,-30} {2,-15}", "Título", "Autor", "Ano");
                    Console.WriteLine(new string('-', 85));
                    foreach (var livro in livros)
                    {
                        string ano = livro.AnoPublicacao > 0 ? livro.AnoPublicacao.ToString() : "Desconhecido";
                        Console.WriteLine("{0,-40} {1,-30} {2,-15}", livro.Titulo, livro.Autor, ano);
                    }
                    Uteis.Pause();
                    Uteis.Clear();
                }
            }
            else if (n == 3)
            {
                Uteis.Title("REMOVER LIVRO");
                Console.WriteLine("{0,-5} {1,-40} {2,-30} {3,-15}", "Nº", "Título", "Autor", "Ano");
                Console.WriteLine(new string('-', 90));
                for (int i = 0; i < livros.Count; i++)
                {
                    string ano = livros[i].AnoPublicacao > 0 ? livros[i].AnoPublicacao.ToString() : "Desconhecido";
                    Console.WriteLine("{0,-5} {1,-40} {2,-30} {3,-15}", i + 1, livros[i].Titulo, livros[i].Autor, ano);
                }
                int indice = Uteis.LerInteiro("Qual o número do livro a ser removido? ") - 1;
                if (indice >= 0 && indice < livros.Count)
                {
                    livros.RemoveAt(indice);
                    Console.WriteLine("Livro removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Número inválido. Nenhum livro foi removido.");
                }
                Uteis.Pause();
                Uteis.Clear();
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Uteis.Pause();
                Uteis.Clear();}
        }
    }
}