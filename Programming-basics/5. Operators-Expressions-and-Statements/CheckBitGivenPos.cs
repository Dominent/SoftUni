using System;

class CheckBitGivenPos
{
    static void Main()
    {
        int val = 0;
        int index = 0;

        val = Convert.ToInt32(Console.ReadLine());
        index = Convert.ToInt32(Console.ReadLine());

        int mask = 1; //0000 0001

        bool bit = ((val >> index) & mask) == 1 ? true : false;
        Console.WriteLine(bit);
    }
}

