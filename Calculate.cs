using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        char operation;

        Console.WriteLine("Введите первое число:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите операцию (+, -, *, /):");
        operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (operation)
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
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль");
                    return;
                }
                break;
            default:
                Console.WriteLine("Ошибка: неверная операция");
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
}
