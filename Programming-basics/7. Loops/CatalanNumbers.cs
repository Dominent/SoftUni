using System;

class CatalanNumbers
{
    static int Factoriel(int number) // Calculates Factoriel of a given number. 
    {
        int val = 1;
        for (int i = number; i >= 1; --i)
        {
            val *= number;
            --number;
        }
        return val;
    }

    static void Main()
    {
        int valN;
        int valK;

        valN = Convert.ToInt32(Console.ReadLine());
        valK = Convert.ToInt32(Console.ReadLine());

        int factN = Factoriel(valN);
        int factK = Factoriel(valK);

        long sum = (factK * factN) / Factoriel(valK - valN);

        Console.WriteLine(sum);
    }
}

