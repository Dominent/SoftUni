using System;

class FibonachiNumbers
{
    public static long Fib(int n)
    {
        long k = 1;
        long l = 0;

        for (int i = 0; i < n/2; i++)
        {
            k += l;
            l += k;
        }
        return l;
    }

    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Fib(input));
    }
}

