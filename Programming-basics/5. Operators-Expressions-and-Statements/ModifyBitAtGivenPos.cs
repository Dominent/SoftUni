using System;

class ModifyBitAtGivenPos
{
    static void Main()
    {
        int val = 0;
        int index = 0;
        int bitVal; // 0 or 1

        int mask = 1; //0000 0001

        val = Convert.ToInt32(Console.ReadLine());
        index = Convert.ToInt32(Console.ReadLine());
        bitVal = Convert.ToInt32(Console.ReadLine());

        if (bitVal == 1)
        {
            Console.WriteLine("{0}", val | (mask << index));
        }
        else if(bitVal == 0)
        {
            Console.WriteLine("{0}", val &~ (mask << index));
        }

    }
}

