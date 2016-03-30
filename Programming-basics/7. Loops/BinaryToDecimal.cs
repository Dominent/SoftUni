using System;


class BinaryToDecimal
{
    static void Main()
    {
        int decimalval = 0;

        string binaryVal = Console.ReadLine();
        int valN = Convert.ToInt32(binaryVal);

        for (int i = 0; i < binaryVal.Length; ++i)
        {
            if (valN % 10 == 1)
            {
                decimalval = decimalval + (1 * (int)Math.Pow(2, i));
            }
            valN = valN / 10;
        }

        Console.WriteLine("{0}", decimalval);
    }
}

