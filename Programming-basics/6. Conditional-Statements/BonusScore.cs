
using System;

class BonusScore
{
    static void Main()
    {
        int score = 0;
        score = Convert.ToInt32(Console.ReadLine());
        if (score > 1 && score < 3)
        {
            score *= 10;
        }
        else if (score > 4 && score < 6)
        {
            score *= 100;
        }
        else if (score > 7 && score < 9)
        {
            score *= 1000;
        }
        else if (score == 0 || score > 9)
        {
            Console.WriteLine("invalid Score");
        }

    }
}

