using System;

class Trapezoid
{
    static void Main()
    {
        double valA = 0d;
        double valB = 0d;
        double valH = 0d;

        valA = Convert.ToDouble(Console.ReadLine());
        valB = Convert.ToDouble(Console.ReadLine());
        valH = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine((((valA + valB) / 2.0)) * valH);
    }
}

