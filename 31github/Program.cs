using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Экземпляр класса App с системным паролем "password"
        App myApp = new App("password");
        // Метод Startup для запуска приложения
        myApp.Startup();
    }
}