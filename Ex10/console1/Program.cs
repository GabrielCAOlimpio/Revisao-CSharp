//Linq C#

using System;

namespace Program;
public class Program
{
    public static void Main()
    {
        List<User> database = new List<User>()
        {
            new User(1, "Gabriel", "gabriel@example.com", "password123"),
            new User(2, "Ana", "ana@example.com", "pass456"),
            new User(3, "Carlos", "carlos@example.com", "pass789"),
            new User(4, "Maria", "maria@example.com", "pass101"),
            new User(5, "João", "joao@example.com", "pass202"),
            new User(6, "Paula", "paula@example.com", "pass303"),
            new User(7, "Pedro", "pedro@example.com", "pass404"),
            new User(8, "Fernanda", "fernanda@example.com", "pass505"),
            new User(9, "Lucas", "lucas@example.com", "pass606"),
            new User(10, "Beatriz", "beatriz@example.com", "pass707")
        };

        //To Avoid the person acess the password, we can create a method that returns a masked password

        var users = database.Select(u => new
        {
            u.UserId,
            u.UserName,
            u.Email,
            MaskedPassword = new string('*', u.Password.Length)
        }).ToList();

        foreach (var user in users)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"UserId: {user.UserId}");    
            Console.WriteLine($"UserName: {user.UserName}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Password: {user.MaskedPassword}");
        }
}
}