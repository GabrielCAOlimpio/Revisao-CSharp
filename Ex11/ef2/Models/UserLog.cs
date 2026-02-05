namespace Facebook.Models;


public class UserLog
{
    private string username = string.Empty;
    private string email = string.Empty;
    private DateTime createdAt;

    private string state = string.Empty;

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
    public string State
    {
        get => state;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Erro! Estado do log é obrigatório!");
            state = value;
        }
    }
}