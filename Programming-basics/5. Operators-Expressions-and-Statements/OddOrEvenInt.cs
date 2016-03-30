using System;

class OddOrEvenInt
{
    static void Main()
    {
        int val = 0;
        val = Convert.ToInt32(Console.ReadLine());

        if (val%2 == 0)
        {
            Console.Write(true);
        }
        else
        {
            Console.Write(false);
        }
        Console.WriteLine();
    }
}

