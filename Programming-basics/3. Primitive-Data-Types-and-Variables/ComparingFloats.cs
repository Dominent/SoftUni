using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001d;
        double? val1;
        double? val2;

        val1 = Convert.ToDouble(Console.ReadLine());
        val2 = Convert.ToDouble(Console.ReadLine());

        if (val1 - val2 < eps)
        {
            Console.WriteLine("The difference {0} < eps", val1 - val2);
        }
        else if(val1 - val2 == eps)
        {
            Console.WriteLine("The difference {0} == eps.We consider the numbers are different.", val1 - val2);
        }
        else // val1 - val2 > eps
        {
            Console.WriteLine("The difference of {0} is too big(> eps)", val1 - val2);
        }

    }
}

