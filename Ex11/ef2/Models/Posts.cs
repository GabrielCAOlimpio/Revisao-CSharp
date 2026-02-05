namespace Facebook.Models;

public class Post
{
    private int id;
    private string content = string.Empty;
    private DateTime createdAt;
    private int userId;

    // Propriedades de navegação (Lazy loading ou Eager loading)
    public User User { get; set; } = null!;

    public int Id
    {
        get => id;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Erro! O ID do post deve ser maior que 0.");
            id = value;
        }
    }

    public string Content
    {
        get => content;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Erro! O conteúdo do post não pode estar vazio.");
            
            if (value.Length > 2000) // Exemplo de validação de tamanho
                throw new ArgumentException("Erro! O conteúdo excede o limite de 2000 caracteres.");

            content = value;
        }
    }

    public int UserId
    {
        get => userId;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Erro! Um post deve estar vinculado a um usuário válido.");
            userId = value;
        }
    }

    public DateTime CreatedAt
    {
        get => createdAt;
        set => createdAt = value;
    }
}