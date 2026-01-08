//INSTANCE METHOD;
//Metodos de instancia;

using System;
namespace Program;

class Program
{
    static void Main(string[] args)
    {
        User.Greeting(); //Calling the static method
        List<User> users = new List<User>
        {
            new User("Raion", 30),
            new User("Bob"),
            new User("Charlie", 25)
        };
        foreach (var user in users)
        {
            user.ShowInfo();
        }
    }
}