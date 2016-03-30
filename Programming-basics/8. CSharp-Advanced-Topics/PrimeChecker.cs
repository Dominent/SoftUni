using System;

class PrimeChecker
{
    public static bool IsPrime(long n)
    {
        for (long i = 2; i < n; i++)
        {
            if (n % 2 == 0) return false;
        }
        return true;
    }
    static void Main()
    {
        long input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(IsPrime(input));
    }
}

