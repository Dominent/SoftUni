
using System;

class ThirdDigit7
{
    static void Main()
    {
        int val = 0;
        val = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}", (val / 100) % 10 == 7 ? true : false);
    }
}

