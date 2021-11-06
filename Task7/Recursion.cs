using System;
using System.Collections.Generic;
using Utilities;

public class Recursion : BaseTask
{
    public override void Start()
    {
        // var theEndResult = TheAction(4);
        // Console.WriteLine(theEndResult);
        var fib = Fibo(11);
        Console.WriteLine(fib);
    }

    private static int TheAction(int num)
    {
        if (num == 1)
        {
            return num;
        }

        return num * TheAction(num - 1);
    }

    private static int Fibo(int num)
    {
        if (num == 1 || num == 0) return num;
        return Fibo(num - 1) + Fibo(num - 2);
    }
}