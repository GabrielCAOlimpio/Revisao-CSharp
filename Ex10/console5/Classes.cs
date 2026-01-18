using System;
namespace Console5.Classes;

public class Categoria
{
    private int categoriaId;
    private string categoriaNome = string.Empty;

    //Propriedade de Navegação
    public List<Produto> Produtos { get; set; } = [];
    public int CategoriaId
    {
        get => categoriaId <= 0 ? throw new Exception("O ID da categoria deve ser maior que zero.") : categoriaId;
        set
        {
            if (value <= 0)
            {
                throw new Exception("O ID da categoria deve ser maior que zero.");
            }
            categoriaId = value;
        }
    }
    public string CategoriaNome
    {
        get => string.IsNullOrEmpty(categoriaNome) ? throw new Exception("O nome da categoria não pode ser vazio.") : categoriaNome;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("O nome da categoria não pode ser vazio.");
            }
            categoriaNome = value;
        }
    }

    public Categoria(int categoriaId, string categoriaNome)
    {
        CategoriaId = categoriaId;
        CategoriaNome = categoriaNome;
    }
}
public class Produto
{
    private int produtoId;
    private string nome = string.Empty;
    private decimal preco;

    //Propriedade de Navegação
    private int categoriaId;    
    public Categoria Categoria { get; set; } = null!;

    public int ProdutoId
    {
        get => produtoId <= 0 ? throw new Exception("O ID do produto deve ser maior que zero.") : produtoId;
        set
        {
            if (value <= 0)
            {
                throw new Exception("O ID do produto deve ser maior que zero.");
            }
            produtoId = value;
        }
    }
    public string Nome
    {
        get => string.IsNullOrEmpty(nome) ? throw new Exception("O nome do produto não pode ser vazio.") : nome;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("O nome do produto não pode ser vazio.");
            }
            nome = value;
        }
    }
    public decimal Preco
    {
        get => preco <= 0 ? throw new Exception("O preço do produto deve ser maior que zero.") : preco;
        set
        {
            if (value <= 0)
            {
                throw new Exception("O preço do produto deve ser maior que zero.");
            }
            preco = value;
        }
    }
    public int CategoriaId
    {
        get => categoriaId <= 0 ? throw new Exception("O ID da categoria deve ser maior que zero.") : categoriaId;
        set
        {
            if (value <= 0)
            {
                throw new Exception("O ID da categoria deve ser maior que zero.");
            }
            categoriaId = value;
        }
    }
    
    public Produto(int produtoId, string nome, decimal preco, int categoriaId)
    {
        ProdutoId = produtoId;
        Nome = nome;
        Preco = preco;
        CategoriaId = categoriaId;
    }
}