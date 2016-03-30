using System;

class NumberComparer
{
    static void Main()
    {
        double val1 = Convert.ToDouble(Console.ReadLine());
        double val2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("{0:F2}", Math.Max(val1, val2));

    }
}

