using System;

public struct User
{
    // Объявляем свойства Username и Password
    public string Username { get; set; }
    public string Password { get; set; }

    // Конструктор структуры User принимает имя пользователя и пароль.
    // Используется для инициализации свойств Username и Password
    // при создании экземпляра User.
    public User(string username, string password)
    {
        Username = username;

        Password = password;
    }
}

