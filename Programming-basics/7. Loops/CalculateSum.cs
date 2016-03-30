using System;

class CalculateSum
{
    static void Main()
    {
        double valN = Convert.ToInt32(Console.ReadLine());
        double valX = Convert.ToInt32(Console.ReadLine());

        double sum = 1d;
        double fact = 1d;
        double prod = 1d;

        for (int i = 1; i < valN + 1; i++)
        {
            fact = fact * i;
            prod = Math.Pow(valX, i);
            sum = sum + (fact / prod);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}

