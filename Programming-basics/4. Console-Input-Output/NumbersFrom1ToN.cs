using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int valN = 0;

        valN = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= valN; ++i)
        {
            Console.WriteLine("{0}", i);
        }
    }
}

