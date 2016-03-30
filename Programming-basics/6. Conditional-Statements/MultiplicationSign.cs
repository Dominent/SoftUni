using System;

class MultiplicationSign
{
    static void Main()
    {
        int neg = 0;

        for (int i = 0; i < 3; ++i)
        {
            if (Convert.ToInt32(Console.ReadLine()) < 0)
            {
                ++neg;
            }
        }
        if (neg % 2 != 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}

