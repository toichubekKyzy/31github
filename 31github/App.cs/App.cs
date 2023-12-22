using System;

public  class App
{

    private string systemPassword;
    // Конструктор класса App принимает системный пароль
    // и сохраняет его в приватное поле systemPassword.
    public App(string Password)
    {
        systemPassword = Password;
    }


    public void Startup ()
    // Метод Startup запускает приложение.
    // Он запрашивает у пользователя имя и пароль,
    // создает пользователя и приветствует его.
    {
        Console.WriteLine("Введите ваше имя: ");
        string userName = Console.ReadLine();

        Console.WriteLine("Введите ваш пароль: ");
        string userPassword = Console.ReadLine();

        User? newUser = CreateUser(userName, userPassword);
        HelloUser(newUser);
    }

    // Метод CreateUser проверяет пароль пользователя с системным паролем.
    // Если пароль верный, создает экземпляр структуры User и возвращает его.
    // Если пароль неверный, возвращает null.
    private User? CreateUser(string username, string password )
    {
        if (password == systemPassword) 
        {
            return new User(username, password);
        }
        return null;
    }
    // Метод HelloUser приветствует пользователя по имени.
    // Если пользователь не был создан (пароль неверный),
    // сообщает об ошибке входа.
    private void HelloUser(User? user)
    { 
        if (user != null)

        {
            Console.WriteLine($"Привет, {user.Value.Username}!");
        }
        else
        {
            Console.WriteLine("Вам не удалось войти в систему!");
        }
    }
}