using System;

class Calculator
{
    static double memory = 0;

    static void Main()
    {
        Console.WriteLine("Калькулятор");

        while (true)
        {
            Console.WriteLine("Введите выражение (например, 2 + 3), 'm+', 'm-', 'mr', 'mc', 'sqrt', 'pow':");
            string input = Console.ReadLine();

            if (input == "exit")
                break;

            if (input == "mc")
            {
                memory = 0;
                Console.WriteLine("Память очищена.");
                continue;
            }

            if (input == "mr")
            {
                Console.WriteLine("Значение в памяти: " + memory);
                continue;
            }

            if (input == "m+")
            {
                double number = ReadNumber("Введите число для добавления в память: ");
                memory += number;
                Console.WriteLine("Число добавлено в память.");
                continue;
            }

            if (input == "m-")
            {
                double number = ReadNumber("Введите число для вычитания из памяти: ");
                memory -= number;
                Console.WriteLine("Число вычтено из памяти.");
                continue;
            }

            if (input == "sqrt")
            {
                double number = ReadNumber("Введите число для извлечения квадратного корня: ");
                double result = Math.Sqrt(number);
                Console.WriteLine("Квадратный корень числа: " + result);
                continue;
            }

            if (input == "pow")
            {
                double baseNum = ReadNumber("Введите основание: ");
                double exponent = ReadNumber("Введите показатель степени: ");
                double result = Math.Pow(baseNum, exponent);
                Console.WriteLine("Результат возведения в степень: " + result);
                continue;
            }

            // Парсинг введенной строки для выполнения операции
            string[] elements = input.Split(' ');
            if (elements.Length != 3)
            {
                Console.WriteLine("Неверный формат ввода.");
                continue;
            }

            double num1 = double.Parse(elements[0]);
            char operation = char.Parse(elements[1]);
            double num2 = double.Parse(elements[2]);

            double res = 0;

            switch (operation)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        res = num1 / num2;
                    else
                        Console.WriteLine("Деление на ноль!");
                    break;
                default:
                    Console.WriteLine("Неверная операция.");
                    break;
            }

            Console.WriteLine("Результат: " + res);
        }
    }

    static double ReadNumber(string message)
    {
        Console.Write(message);
        return Convert.ToDouble(Console.ReadLine());
    }
}
