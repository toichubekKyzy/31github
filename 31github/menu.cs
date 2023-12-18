string hello;
hello = "hi";
string world = "Hello";
//потихоньку изучаем
const string kek = "Hello Kek";
string input = Console.ReadLine();
Console.WriteLine(input);
//ccылочные тип
string reference = "Hello, world!";
int value = 10;
string value1 = null;
string value2 = Console.ReadLine();


int number = 10;
if (number > 0)
{
    Console.WriteLine("Число положительное");
}
else if (number == 0)
{
    Console.WriteLine("число равна нулю");
}
else
{
    Console.WriteLine("Число отрицательное");
}


string input3 = "Case2";

switch (input)
{
    case "Case1":
        Console.WriteLine("Вы выбрали Case1");
        break;
    case "Case2":
        Console.WriteLine("Вы выбрали Case2");
        break;
    default:
        Console.WriteLine("Действие по умолчанию");
        break;
}




int number1 = 10;
string result = (number > 0) ? "Число положительное" : "Число не положительное или равно нулю";
Console.WriteLine(result);

while (true)
{
    Console.WriteLine("Это бесконечный цикл!");
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("test");
}


for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}


do
{
    Console.WriteLine("hello");
} while (false);
//в циклах я чуть чуть слаба


int[] array = { 1, 2, 3, 4, 5 };

foreach (int numb in array)
{
    Console.WriteLine(numb);
}
Console.WriteLine(array.Length);
DateTime date = DateTime.Now;
DateTime dateOneYearLater = date.AddYears(1);
// 26 не поняла
string firstName = "dfgh";
string lastName = "fghj";

string name = $"Привет, {firstName} {lastName}!";
//28 -
//29-
//33 и дальше я не особо поняла, мои знания этим и заканчиваются((
//просто меня неделю не было и я отстала(