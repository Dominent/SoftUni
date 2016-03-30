using System;

class PrintMatrix
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= valN; ++i)
        {
            Console.Write("{0}", i);
            for (int j = i + 1; j <= valN + (i - 1); ++j)
            {
                Console.Write(" {0}", j);
            }
            Console.WriteLine();
        }
    }
}

