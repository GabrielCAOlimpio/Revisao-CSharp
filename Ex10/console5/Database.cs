using System;
using System.Collections.Generic;
using System.Linq;
using Console5.Classes;

namespace Console5.Database;

public class Db
{
    public List<Categoria> Categorias { get; set; }
    public List<Produto> Produtos { get; set; }

    public Db()
    {
        // 1. Criando as 5 Categorias Principais
        Categorias = 
        [
            new Categoria(1, "Eletrônicos"),
            new Categoria(2, "Alimentos"),
            new Categoria(3, "Vestuário"),
            new Categoria(4, "Limpeza"),
            new Categoria(5, "Papelaria")
        ];

        // 2. Criando os 20 Produtos
        Produtos = 
        [
            // Eletrônicos (Cat 1)
            new Produto(1, "Smartphone", 1500.00m, 1),
            new Produto(2, "Fone de Ouvido", 150.00m, 1),
            new Produto(3, "Carregador Rápido", 80.00m, 1),
            new Produto(4, "Mouse Sem Fio", 120.00m, 1),

            // Alimentos (Cat 2)
            new Produto(5, "Arroz 5kg", 25.00m, 2),
            new Produto(6, "Feijão Preto", 8.50m, 2),
            new Produto(7, "Café Torrado", 18.00m, 2),
            new Produto(8, "Azeite de Oliva", 35.00m, 2),

            // Vestuário (Cat 3)
            new Produto(9, "Camiseta Algodão", 45.00m, 3),
            new Produto(10, "Calça Jeans", 120.00m, 3),
            new Produto(11, "Meias (Par)", 12.00m, 3),
            new Produto(12, "Tênis Esportivo", 250.00m, 3),

            // Limpeza (Cat 4)
            new Produto(13, "Detergente", 2.50m, 4),
            new Produto(14, "Desinfetante", 12.00m, 4),
            new Produto(15, "Sabão em Pó", 22.00m, 4),
            new Produto(16, "Esponja de Aço", 4.00m, 4),

            // Papelaria (Cat 5)
            new Produto(17, "Caderno 10 Matérias", 30.00m, 5),
            new Produto(18, "Estojo de Canetas", 25.00m, 5),
            new Produto(19, "Resma de Papel A4", 28.00m, 5),
            new Produto(20, "Mochila Escolar", 150.00m, 5)
        ];

        // 3. AMARRAÇÃO (Vínculo Bidirecional)
        // Vamos automatizar o vínculo para você não fazer um por um
        foreach (var p in Produtos)
        {
            // Busca a categoria correspondente ao ID do produto
            var cat = Categorias.FirstOrDefault(c => c.CategoriaId == p.CategoriaId);
            
            if (cat != null)
            {
                p.Categoria = cat;      // O Produto agora conhece a Categoria
                cat.Produtos.Add(p);    // A Categoria agora conhece o Produto
            }
        }
    }
}