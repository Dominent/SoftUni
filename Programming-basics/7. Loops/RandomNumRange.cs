using System;


class RandomNumRange
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());
        Random r = new Random();

        for (int i = 0; i < valN; i++)
        {
            Console.Write("{0,2}", r.Next(min, max));
        }
        Console.WriteLine();
    }
}

