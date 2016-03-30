using System;

class Extract3RdBit
{
    static void Main()
    {
        int val = 0;
        val = Convert.ToInt32(Console.ReadLine());
        int mask = 1; //0001
        
        if (((val >> 3) & mask) == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}

