using System;

class DecimalToBinary
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine()); // 32

        int[] binary = new int[10]; // size of 10

        for (int i = valN, j = 0; i != 0; i = (i / 2), j++)
        {
            binary[j] = i % 2;
        }

        Console.Write("Decimal: {0} Binary: ", valN);

        for (int i = 7; i >= 0; i--)
        {
            Console.Write(binary[i]);
        }
        Console.WriteLine();
    }
}

