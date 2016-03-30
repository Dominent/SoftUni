using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split();
        int prodEven = 1;
        int prodOdd = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                prodOdd *= Convert.ToInt32(numbers[i]);
            }
            else
            {
                prodEven *= Convert.ToInt32(numbers[i]);
            }
        }
        if (prodOdd == prodEven)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("product = {0}",prodOdd);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("odd_product = {0}", prodOdd);
            Console.WriteLine("even_product = {0}", prodEven);
        }
    }
}

