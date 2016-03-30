using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double val1 = 0.0d;
        double val2 = 0.0d;

        val1 = Convert.ToDouble(Console.ReadLine());
        val2 = Convert.ToDouble(Console.ReadLine());

        if (val1 > val2)
            Console.WriteLine("{0} {1}", val1, val2);
        if (val1 < val2)
            Console.WriteLine("{0} {1}", val2, val1);

    }
}

