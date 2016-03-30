using System;

class FourDigitNum
{
    static void Main()
    {
        int input = 0;
        int sum = 0;
        input = Convert.ToInt32(Console.ReadLine());

        int[] temp = new int[4];

        for (int i = 3; i > -1; --i)
        {
            temp[i] = input % 10;
            input /= 10;
        }
        foreach (var val in temp)
        {
            sum += val;
        }
        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}", temp[3], temp[2], temp[1], temp[0]);
        Console.WriteLine("{0}{1}{2}{3}", temp[3], temp[0], temp[1], temp[2]);
        Console.WriteLine("{0}{1}{2}{3}", temp[0], temp[2], temp[1], temp[3]);
    }
}

