
using System;

class Sort3Numbers
{
    static void Main()
    {
        int val1 = 0;
        int val2 = 0;
        int val3 = 0;

        val1 = Convert.ToInt32(Console.ReadLine());
        val2 = Convert.ToInt32(Console.ReadLine());
        val3 = Convert.ToInt32(Console.ReadLine());
        if (val1 > val2 && val1 > val3)
        {
            if(val2 > val3)
                Console.WriteLine("{0} > {1} > {2}", val1, val2, val3);
            else if(val2 < val3)
                Console.WriteLine("{0} > {1} > {2}", val1, val3, val2);
        }
        else if(val2 > val1 && val2 > val3)
        {
            if (val1 > val3)
                Console.WriteLine("{0} > {1} > {2}", val2, val1, val3);
            else if (val1 < val3)
                Console.WriteLine("{0} > {1} > {2}", val2, val3, val1);
        }
        else if(val3 > val1 && val3 > val2)
        {
            if (val2 > val1)
                Console.WriteLine("{0} > {1} > {2}", val3, val2, val1);
            else if (val2 < val1)
                Console.WriteLine("{0} > {1} > {2}", val3, val1, val2);
        }
        else
        {
            Console.WriteLine("Equal");
        }
    }
}

