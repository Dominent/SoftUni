using System;

class DecimalToHex
{
    static void Main()
    {
        string input = Console.ReadLine();
        int valN = Convert.ToInt32(input);

        int[] numbers = new int[input.Length + 1];

        for (int i = 0; i <= input.Length; ++i)
        {
            numbers[i] = valN % 16;
            valN = valN / 16;
        }

        for (int i = input.Length; 0 <= i; --i)
        {
            if (numbers[i] >= 10)
            {
                switch (numbers[i])
                {
                    case 10:
                        Console.Write("A");
                        break;
                    case 11:
                        Console.Write("B");
                        break;
                    case 12:
                        Console.Write("C");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("E");
                        break;
                    case 15:
                        Console.Write("F");
                        break;
                }
            }
            else if(numbers[i] != 0)
            {
                Console.Write(" {0}", numbers[i]);
            }
        }
        Console.WriteLine();
    }
}


