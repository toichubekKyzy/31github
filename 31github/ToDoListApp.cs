using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using _31github;

namespace _31github;


// Класс для управления списком задач
//Логика управления задачами в классе ToDoListManager, который содержит методы для добавления, отображения и удаления задач.
class ToDoListManager
{
    private List<string> tasks;

    public ToDoListManager()
    {
        tasks = new List<string>();
    }

    public void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine("Задача добавлена!");
    }

    public void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст.");
        }
        else
        {
            Console.WriteLine("Список задач:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    public void RemoveTask(int index)
    {
        if (index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Задача удалена!");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }
}