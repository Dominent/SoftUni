using System;
class NumbersNotDivThreeSeven
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < valN; i++)
        {
            if (i % 5 == 0 && i % 7 == 0)
                Console.WriteLine(i);
        }
    }
}

