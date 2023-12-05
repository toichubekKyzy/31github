using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using _31github;

namespace _31github;


public class Cinema
{
private const int MovieChoiceId = 1;
private const int MovieShedId = 2;
private int[] availableOperationIds = { MovieChoiceId, };

    public void ShowGreetings()
{
    Console.WriteLine("********************************");
    Console.WriteLine("**********************************");
    Console.WriteLine("*  Welcome to the cinema   *********");
    Console.WriteLine("*************************************");
    Console.WriteLine("***************************************");
    Thread.Sleep(3000);
    Console.Clear();
}

public void ShowMenu()
{
    Console.WriteLine("POSTER");
    Console.WriteLine($"{MovieChoiceId} - Movie selection");

    Console.WriteLine($"{MovieShedId} - Shedule");
    Console.WriteLine("Please choose necessary option");
    int operationId = InputHelpers.ReadNumber("Please choose necessary option");
        ProcessOperation(operationId);
    }
}
ы

private void ProcessOperation(int operationId)
{
    switch (operationId)
    {
        case ShowBalanceOperationId:
            ShowBalance();
            break;
        case TopUpBalanceOperationId:
            ChangeBalance(CardOperation.TopUp);
            break;
        case WithdrawFromBalanceOperationId:
            ChangeBalance(CardOperation.Withdraw);
            break;
        default:
            ProcessIncorrectOperationId();
            break;
    }
}
