using System;

class Sum5Numbers
{
    static void Main()
    {
        double sum = 0;

        string[] input = Console.ReadLine().Split();

        foreach (var val in input)
        {
            sum += Convert.ToDouble(val);
        }

        Console.WriteLine("{0}", sum);

    }
}

