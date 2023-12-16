it﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Helpers;
using _31github;

namespace _31github;

class Calculator
{
    static void Main()
    {
        double num1, num2, result;
        char op;

        Console.WriteLine("Введите первое число:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите операцию (+, -, *, /):");
        op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Ошибка: неправильная операция");
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
}
