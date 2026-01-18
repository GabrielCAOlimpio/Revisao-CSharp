using System;
namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        List<Categoria> categorias = 
        [
            new Categoria(1, "Eletrônicos"),
            new Categoria(2, "Eletrodomésticos"),
            new Categoria(3, "Informática"),
            new Categoria(4, "Móveis"),
            new Categoria(5, "Moda & Acessórios"),
            new Categoria(6, "Esporte & Lazer"),
            new Categoria(7, "Beleza & Perfumaria"),
            new Categoria(8, "Brinquedos"),
            new Categoria(9, "Livros & Papelaria"),
            new Categoria(10, "Automotivo"),
            new Categoria(11,"Streaming")
        ];
        List<Produto> produtos = 
        [
            // 1 - Eletrônicos
            new Produto(1, "Smartphone Samsung A15 5G 256GB", 1299.50m, 1),
            new Produto(2, "iPhone 15 Pro 128GB", 7299.00m, 1),
            new Produto(3, "Smart TV LED 50'' 4K", 2150.00m, 1),
            new Produto(4, "Fone de Ouvido Bluetooth Noise Cancelling", 450.00m, 1),
            new Produto(5, "Tablet Android 11'' 128GB", 1590.00m, 1),

            // 2 - Eletrodomésticos
            new Produto(6, "Geladeira Frost Free 400L", 3200.00m, 2),
            new Produto(7, "Máquina de Lavar 12kg", 2100.00m, 2),
            new Produto(8, "Micro-ondas 30L Inox", 650.00m, 2),
            new Produto(9, "Ar Condicionado Split 12000 BTUs", 1850.00m, 2),
            new Produto(10, "Aspirador de Pó Robô", 890.00m, 2),

            // 3 - Informática
            new Produto(11, "Notebook Gamer RTX 4060", 5800.00m, 3),
            new Produto(12, "Monitor 27'' IPS 144Hz", 1250.00m, 3),
            new Produto(13, "Teclado Mecânico RGB", 350.00m, 3),
            new Produto(14, "Mouse Gamer 12000 DPI", 180.00m, 3),
            new Produto(15, "Impressora Tanque de Tinta", 950.00m, 3),

            // 4 - Móveis
            new Produto(16, "Cadeira Gamer Ergonômica", 850.00m, 4),
            new Produto(17, "Mesa de Escritório em L", 450.00m, 4),
            new Produto(18, "Sofá 3 Lugares Retrátil", 2100.00m, 4),
            new Produto(19, "Guarda-Roupa Casal 6 Portas", 1500.00m, 4),
            new Produto(20, "Estante para Livros Moderna", 320.00m, 4),

            // 5 - Moda & Acessórios
            new Produto(21, "Tênis Esportivo Corrida", 299.90m, 5),
            new Produto(22, "Relógio de Pulso Analógico", 150.00m, 5),
            new Produto(23, "Jaqueta Corta Vento", 180.00m, 5),
            new Produto(24, "Mochila Impermeável Notebook", 120.00m, 5),
            new Produto(25, "Óculos de Sol Proteção UV", 85.00m, 5),

            // 6 - Esporte & Lazer
            new Produto(26, "Bicicleta Aro 29 21 Marchas", 1350.00m, 6),
            new Produto(27, "Kit Halteres 10kg", 180.00m, 6),
            new Produto(28, "Tapete de Yoga Antiderrapante", 65.00m, 6),
            new Produto(29, "Prancha de Stand Up Paddle", 2200.00m, 6),
            new Produto(30, "Barraca de Camping 4 Pessoas", 450.00m, 6),

            // 7 - Beleza & Perfumaria
            new Produto(31, "Perfume Importado 100ml", 450.00m, 7),
            new Produto(32, "Secador de Cabelo Profissional", 280.00m, 7),
            new Produto(33, "Kit Skincare Facial Completo", 150.00m, 7),
            new Produto(34, "Prancha Alisadora Cerâmica", 120.00m, 7),
            new Produto(35, "Máquina de Cortar Cabelo", 95.00m, 7),

            // 8 - Brinquedos
            new Produto(36, "Blocos de Montar 500 Peças", 220.00m, 8),
            new Produto(37, "Boneca Articulada com Acessórios", 130.00m, 8),
            new Produto(38, "Carro de Controle Remoto", 180.00m, 8),
            new Produto(39, "Jogo de Tabuleiro Estratégia", 150.00m, 8),
            new Produto(40, "Piscina de Bolinhas Inflável", 90.00m, 8),

            // 9 - Livros & Papelaria
            new Produto(41, "O Senhor dos Anéis - Edição Luxo", 120.00m, 9),
            new Produto(42, "Kindle Paperwhite 16GB", 750.00m, 9),
            new Produto(43, "Planner 2026 Organização", 45.00m, 9),
            new Produto(44, "Kit Canetas Coloridas 24 Cores", 65.00m, 9),
            new Produto(45, "Caderno Universitário Capa Dura", 35.00m, 9),

            // 10 - Automotivo
            new Produto(46, "Pneu Aro 15 195/55", 380.00m, 10),
            new Produto(47, "Central Multimídia Android", 650.00m, 10),
            new Produto(48, "Capa de Banco Couro Sintético", 220.00m, 10),
            new Produto(49, "Óleo para Motor 5W30 1L", 45.00m, 10),
            new Produto(50, "Lâmpada LED Farol H7", 85.00m, 10),
        ];

        var produtosEcategoria = categorias
        .GroupJoin(
            produtos,
            c => c.CategoriaId,
            p => p.CategoriaId,
            (c, prods) => new { c, prods }
        )
        .SelectMany(
            temp => temp.prods.DefaultIfEmpty(), // Se não tiver produto, cria um nulo
            (temp, p) => new
            {
                CategoriaNome = temp.c.Nome,
                ProdutoNome = p?.Nome ?? "--- Sem Produtos ---",
                Preco = p?.Preco ?? 0m
            }
        );
        // Cabeçalho da Tabela
        Console.WriteLine(new string('=', 75));
        Console.WriteLine($"{"Produto",-45} | {"Preço",-12} | {"Categoria",-15}");
        Console.WriteLine(new string('-', 75));

        foreach (var pc in produtosEcategoria)
        {
            Console.WriteLine($"{pc.ProdutoNome,-45} | {pc.Preco,12:C2} | {pc.CategoriaNome,-15}");
        }

        Console.WriteLine(new string('=', 75));
        
        
    }
}