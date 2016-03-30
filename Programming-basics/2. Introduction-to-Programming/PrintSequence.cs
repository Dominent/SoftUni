using System;

class PrintSequence
{
    static void Main()
    {
        int[] numbers = { 2, -3, 4, -5, 6, -7, 8, -9, 10, -11 };
        for (int i = 0; i < 10; ++i)
        {
            Console.Write("{0,2},", numbers[i]);
        }
        Console.WriteLine();
    }
}

