﻿using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);

        int tmp = a;
        a = b;
        b = tmp;
        Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
    }
}

