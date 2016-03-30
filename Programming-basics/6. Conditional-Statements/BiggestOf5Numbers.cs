using System;

class BiggestOf5Numbers
{
    static void Main()
    {
        int max = 0;

        for (int i = 0; i < 5; ++i)
        {
            int temp = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
                max = temp;
            else
            {
                if (max < temp)
                {
                    max = temp;
                }
            }
        }
        Console.WriteLine(max);


    }
}

