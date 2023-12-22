using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public  class App
{

        private string systemPassword;
        public App(string Password)
        {
            systemPassword = Password;
        }
        public void Startup ()
        {
            Console.WriteLine("Введите ваше имя: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Введите ваш пароль: ");
            string userPassword = Console.ReadLine();

            User  newUser = (User)CreateUser(userName, userPassword);
            HelloUser(newUser);
        }
         

        private User? CreateUser(string username, string password )
        {
            if (password == systemPassword) 
            {
               return new User(username, password);
            }
            return null;
        }

        private void HelloUser(User? user)
        { 
            if (user != null) 
            {
                Console.WriteLine($"Привет, {user}!");
            }
            else
            {
                Console.WriteLine("Вам не удалось войти в систему!");
            }

        }

 }
