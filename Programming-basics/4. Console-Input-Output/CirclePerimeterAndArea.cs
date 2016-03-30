using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double valR = 0;

        valR = Convert.ToDouble(Console.ReadLine());
        Console.Write("Area: {0:F2}\n" +
                      "Perimeter: {1:F2}", (Math.PI * Math.Pow(valR, 2)), 2* Math.PI * valR );
        Console.WriteLine();

    }
}

