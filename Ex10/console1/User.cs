using System;

namespace Program
{
    public class User
    {
        private int userId;
        private string userName = string.Empty;
        private string email = string.Empty;
        private string password = string.Empty;

        public int UserId
        {
            get => userId > 0 ? userId : throw new Exception("UserId must be greater than zero.");
            set
            {
                if (value <= 0)
                {
                    throw new Exception("UserId must be greater than zero.");
                }
                userId = value;
            }
        }
        public string UserName
        {
            get => !string.IsNullOrWhiteSpace(userName) ? userName : throw new Exception("UserName cannot be null or empty.");
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("UserName cannot be null or empty.");
                }
                userName = value;
            }
        }
        public string Email
        {
            get => !string.IsNullOrWhiteSpace(email) ? email : throw new Exception("Email cannot be null or empty.");
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Email cannot be null or empty.");
                }
                email = value;
            }
        }
        public string Password
        {
            get => !string.IsNullOrWhiteSpace(password) ? password : throw new Exception("Password cannot be null or empty.");
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Password cannot be null or empty.");
                }
                else if (value.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters long.");
                }
                password = value;
            }
        }
        public User(int userId, string userName, string email, string password)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            Password = password;
        }
    }
}