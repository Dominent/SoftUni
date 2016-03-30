using System;

class ProjectTwo
{
    static void Main()
    {
        long valN = Convert.ToInt64(Console.ReadLine());

        char[] numbers = new char[valN];
        int countA = 0;
        int countB = 0;
        int countC = 0;
        int countD = 0;

        for (int i = 0; i < valN; i++)
        {
            long temp = Convert.ToInt64(Console.ReadLine());
            if (temp % 4 == 0)
            {
                numbers[i] = 'a';
                countA++;
            }
            if (temp % 4 == 1)
            {
                numbers[i] = 'b';
                countB++;
            }
            if (temp % 4 == 2)
            {
                numbers[i] = 'c';
                countC++;
            }
            if (temp % 4 == 3)
            {
                numbers[i] = 'd';
                countD++;
            }
        }
        for (int i = 0; i < valN; i++)
        {
            if (i == valN - 1)
            {
                Console.Write("{0}", numbers[i]);
            }
            else
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Answer A: {0}", countA);
        Console.WriteLine("Answer B: {0}", countB);
        Console.WriteLine("Answer C: {0}", countC);
        Console.WriteLine("Answer D: {0}", countD);
    }
}



