using System;


class QuadraticEquation
{
    public static void QuadEquation(double val1, double val2, double val3)
    {
        double determinant = (Math.Pow(val2, 2) - (4 * val1 * val3));
        if (determinant > 0)
        {
            double valX1 = (-val2 + Math.Sqrt(determinant)) / (2 * val1);
            double valX2 = (-val2 - Math.Sqrt(determinant)) / (2 * val1);
            Console.WriteLine("roots: x2 = {0}, x1 = {1}", valX1, valX2);
        }
        else if (determinant == 0)
        {
            double valX = -val2 / (2 * val1);
            Console.WriteLine("roots: x = {0}", valX);
        }
        else
        {
            Console.WriteLine("No Real Roots");
        }
        
    }
    static void Main()
    {
        double valA = 0;
        double valB = 0;
        double valC = 0;

        valA = Convert.ToDouble(Console.ReadLine());
        valB = Convert.ToDouble(Console.ReadLine());
        valC = Convert.ToDouble(Console.ReadLine());

        QuadEquation(valA, valB, valC);


    }
}

