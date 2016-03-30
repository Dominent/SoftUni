using System;

namespace ExtractBitFromInt
{
    class ExtractBitFromInt
    {
        static void Main()
        {
            int val = 0;
            int index = 0;

            val = Convert.ToInt32(Console.ReadLine());
            index = Convert.ToInt32(Console.ReadLine());

            int mask = 1; //0000 0001
            if (((val >> index) & mask) == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
