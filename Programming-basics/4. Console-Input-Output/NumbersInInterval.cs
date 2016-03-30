
using System;

class NumbersInInterval
{
    static void Main()
    {
        uint val1 = 0;
        uint val2 = 0;
        int count = 0;
        val1 = Convert.ToUInt32(Console.ReadLine());
        val2 = Convert.ToUInt32(Console.ReadLine());

        for (uint i = val1; i <= val2; ++i)
        {
            if (i % 5 == 0)
            {
                ++count;
            }
        }
        Console.Write(count);
        Console.WriteLine();
    }
}

