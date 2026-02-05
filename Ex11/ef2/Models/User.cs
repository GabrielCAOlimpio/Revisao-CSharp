namespace Facebook.Models;


public class User
{
    private int id;
    private string username = string.Empty;
    private string email = string.Empty;
    private DateTime createdAt;

    public List<Post> Posts = null!;

    public int Id
    {
        get => id;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Erro! Não é possível atribuir um id menor ou igual a 0");

            id = value; 
        }
    }

    public string Username
    {
        get => username;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Erro! Username é obrigatório!");
            username = value;
        }
    }

    public string Email
    {
        get => email;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Erro! Email é obrigatório!");
            email = value;
        }
    }

    public DateTime CreatedAt
    {
        get => createdAt;
        set => createdAt = value;
    }
}