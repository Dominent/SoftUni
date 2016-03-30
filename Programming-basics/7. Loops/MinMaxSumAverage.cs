
using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());

        List<int> input = new List<int>();

        for (int i = 0; i < valN; i++)
        {
            input.Add(Convert.ToInt32(Console.ReadLine()));
        }
        //Functional Programming Baby
        Console.WriteLine("{0} {1} {2} {3}", input.Max(), input.Min(), input.Sum(), input.Average());
    }
}

