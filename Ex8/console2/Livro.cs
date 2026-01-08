namespace Program;

public class Livro
{
    private string titulo = string.Empty;
    private string autor = string.Empty;
    private int anoPublicacao = 0;

    public string Titulo
    {
        get => string.IsNullOrWhiteSpace(titulo) ? throw new InvalidOperationException("O título não foi definido.") : titulo;
    
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O título não pode ser vazio.");
            }
            titulo = value;
        }
    }
    public string Autor
    {
        get => string.IsNullOrWhiteSpace(autor) ? throw new InvalidOperationException("O autor não foi definido.") : autor;
    
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O autor não pode ser vazio.");
            }
            autor = value;
        }
    }
    public int AnoPublicacao
    {
        get => anoPublicacao <= 0 ? throw new InvalidOperationException("O ano de publicação não foi definido.") : anoPublicacao;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("O ano de publicação não pode ser negativo.");
            }
            anoPublicacao = value;
        }
    }

    public Livro(string titulo, string autor)
    {
        this.Titulo = titulo;
        this.Autor = autor;
    }
    public Livro(string titulo, string autor, int anoPublicacao) : this(titulo, autor)
    {
        this.AnoPublicacao = anoPublicacao;
    }
}
    