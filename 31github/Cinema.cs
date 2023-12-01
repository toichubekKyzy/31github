using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using _31github;

namespace _31github;


public class Cinema
{
private const int MovieChoice = 1;
private const int MovieShed = 2;

public void ShowGreetings()
{
    Console.WriteLine("****************************");
    Console.WriteLine("*                          *");
    Console.WriteLine("*  Welcome to the cinema   *");
    Console.WriteLine("*                          *");
    Console.WriteLine("****************************");
    Thread.Sleep(3000);
    Console.Clear();
}

public void ShowMenu()
{
    Console.WriteLine("POSTER");
    Console.WriteLine($"{MovieChoice} - Movie selection");

    Console.WriteLine($"{MovieShed} - Shedule");
    Console.WriteLine("Please choose necessary option");


}
}

