using System;

class DivideBy5And7
{
    public static bool CheckDivides(int num)
    {
        if (num > 0)
        {
            if (num % 5 == 0 && num % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int val = 0;
        val = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CheckDivides(val));
    }
}

