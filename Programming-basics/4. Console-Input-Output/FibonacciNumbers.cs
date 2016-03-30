using System;

class FibonacciNumbers
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());

        Console.Write("{0,-3}|", valN);
        for (int i = 0, k = 1, j = 0; j < valN;++j)
        {
            int temp = i;
            Console.Write("{0,3}",i);
            i += k;
            k = temp;
        }
        Console.WriteLine();
    }
}

