using System;
using System.Collections.Generic;

class SumOfNNumbers
{
    static void Main()
    {
        int valN = 0;
        double sum = 0d;

        List<double> valList;
        valList = new List<double>();
        valN = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= valN; ++i)
        {
            valList.Add(Convert.ToDouble(Console.ReadLine()));
        }
        foreach (var val in valList)
        {
            sum += val;
        }

        Console.WriteLine(sum);
    }
}

