using System;

class SumOf3Numbers
{
    static void Main()
    {
        double valA = 0;
        double valB = 0;
        double valC = 0;

        valA = Convert.ToDouble(Console.ReadLine());
        valB = Convert.ToDouble(Console.ReadLine());
        valC = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("{0}" ,(valA + valB + valC));
    }
}
