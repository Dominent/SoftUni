//(X−X1)^2+(Y−Y1)^2≤R2(X−X1)^2+(Y−Y1)^2≤R2

using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double valX = 0;
            double valY = 0;
            int rad = 2;

            valX = Convert.ToDouble(Console.ReadLine());
            valY = Convert.ToDouble(Console.ReadLine());

            if (rad >= Math.Sqrt(Math.Pow(valX, 2) + Math.Pow(valY, 2)))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
