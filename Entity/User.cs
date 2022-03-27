﻿namespace Entity
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public User(Guid id, string login, string password)
        {
            Id = id;

            if (login != null)
            {
                Login = login;
            }
            else
            {
                throw new ArgumentNullException(nameof(login));
            }
            if (password != null)
            {
                Password = password;
            }
            else
            {
                throw new ArgumentNullException(nameof(password));
            }

        }
    }
}