using System;

class CalculateNDivKFact
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());
        int valK = Convert.ToInt32(Console.ReadLine());

        int factN = 1;
        int factK = 1;
        long sum = 0;

        for (int i = 1; i <= valN; i++)
        {
            if (valK >= i) factK = factK * i;
            factN = factN * i;

            sum = factN / factK;
        }

        Console.WriteLine("{0:F5}", sum);
    }
}

