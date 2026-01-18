using System;
namespace Program;

public class Produto
{
    private int produtoId;
    private string nome = string.Empty;
    private decimal preco;
    private int categoriaId;

    public int ProdutoId
    {
        get => produtoId > 0 ? produtoId : throw new Exception("ProdutoId must be greater than zero.");
        set
        {
            if (value <= 0)
            {
                throw new Exception("ProdutoId must be greater than zero.");
            }
            produtoId = value;
        }
    }
    public string Nome
    {
        get => !string.IsNullOrWhiteSpace(nome) ? nome : throw new Exception("Nome cannot be null or empty.");
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Nome cannot be null or empty.");
            }
            nome = value;
        }
    }
    public decimal Preco
    {
        get => preco >= 0 ? preco : throw new Exception("Preco cannot be negative.");
        set
        {
            if (value < 0)
            {
                throw new Exception("Preco cannot be negative.");
            }
            preco = value;
        }
    }

    public int CategoriaId
    {
        get => categoriaId > 0 ? categoriaId : throw new Exception("CategoriaId must be greater than zero.");
        set
        {
            if (value <= 0)
            {
                throw new Exception("CategoriaId must be greater than zero.");
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

public class Categoria
{
    private int categoriaId;
    private string nome = string.Empty;

    public int CategoriaId
    {
        get => categoriaId > 0 ? categoriaId : throw new Exception("CategoriaId must be greater than zero.");
        set
        {
            if (value <= 0)
            {
                throw new Exception("CategoriaId must be greater than zero.");
            }
            categoriaId = value;
        }
    }
    public string Nome
    {
        get => !string.IsNullOrWhiteSpace(nome) ? nome : throw new Exception("Nome cannot be null or empty.");
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Nome cannot be null or empty.");
            }
            nome = value;
        }
    }
    public Categoria(int categoriaId, string nome)
    {
        CategoriaId = categoriaId;
        Nome = nome;
    }
}