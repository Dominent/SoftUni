
using System;

class PrimeNumber
{
    static void Main()
    {
        int val = 0;
        val = Convert.ToInt32(Console.ReadLine());
       
        if (val >= 2)
        {
            for (int i = 2; i <= val*val; ++i)
            {
                if (val%i == 0)
                {
                    Console.WriteLine(false);
                    break;
                }
                else
                {
                    Console.WriteLine(false);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

