using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using _31github;

namespace _31github;
//Класс Program содержит только логику интерфейса пользователя и вызов методов из ToDoListManager
//Эти комментарии я оставила себе, чтобы было понятно и для закрепления. Особо не обращать внимание
class Program
{
    static void Main(string[] args)
    {
        ToDoListManager toDoList = new ToDoListManager();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Показать задачи");
            Console.WriteLine("3. Удалить задачу");
            Console.WriteLine("4. Выйти");

            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите новую задачу: ");
                    string task = Console.ReadLine();
                    toDoList.AddTask(task);
                    break;
                case "2":
                    toDoList.ShowTasks();
                    break;
                case "3":
                    Console.Write("Введите номер задачи для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        toDoList.RemoveTask(index);
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Введите число.");
                    }
                    break;
                case "4":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите снова.");
                    break;
            }
        }
    }
}