using System;

class BitsExchangeAdvanced
{
    static int SwitchBits(int input, int startP, int startQ, int sizeK)
    {
        int[] bitVal;
        bool[] isOne;

        isOne = new bool[sizeK * 2];
        bitVal = new int[sizeK * 2];

        int mask = 1;
        int mid = sizeK;

        for (int i = 0; i < sizeK; ++i)
        {
            isOne[i] = (input & (mask << (startQ + i))) > 0 ? true : false;
            bitVal[i] = isOne[i] ? (mask << (startQ + i)) : 0;

            isOne[mid + i] = (input & (mask << (startP + i))) > 0 ? true : false;
            bitVal[mid + i] = isOne[mid + i] ? input & (mask << (startP + i)) : 0;
        }
        for (int i = 0; i < sizeK; ++i)
        {
            if (bitVal[i] == bitVal[mid + i] || isOne[i] == isOne[mid + i])
            {
                continue;
            }
            else
            {
                if
                    (isOne[i]) input = input | (bitVal[i] >> ((startQ - startP)));
                else
                    input = isOne[mid + i] ? input ^ (mask << (startP + i)) : input & ~(mask << (startP + i));

                if (isOne[mid + i])
                    input = input | (bitVal[mid + i] << ((startQ - startP)));
                else
                    input = isOne[i] ? input ^ (mask << (startQ + i)) : input & ~(mask << (startQ + i));
            }
        }
        return input;
    }

    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int startP = Convert.ToInt32(Console.ReadLine());
        int startQ = Convert.ToInt32(Console.ReadLine());
        int sizeK = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(0 + Convert.ToString(SwitchBits(input, startP, startQ, sizeK), 2));
    }
}

