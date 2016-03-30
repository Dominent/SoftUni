using System;

// Converts Char to Int !
/* 0 – 48
   1 – 49                  
   2 – 50
   3 – 51
   4 – 52
   5 – 53
   6 – 54
   7 – 55
   8 – 56
   9 – 57 */

class HexToDecimal
{
    static void Main()
    {
        int decimalVal = 0;
        int temp;

        string input = Console.ReadLine();

        for (int i = input.Length - 1, j = 0; i >= 0; --i, ++j)
        {
            switch (input[i])
            {
                case 'A':
                    temp = 10;
                    break;
                case 'B':
                    temp = 11;
                    break;
                case 'C':
                    temp = 12;
                    break;
                case 'D':
                    temp = 13;
                    break;
                case 'E':
                    temp = 14;
                    break;
                case 'F':
                    temp = 15;
                    break;
                default:
                    {
                        temp = Convert.ToInt32(input[i]);
                        temp = temp - 48;
                    }
                    break;
            }
            decimalVal = decimalVal + (int)(temp * Math.Pow(16, j));
        }
        Console.WriteLine(decimalVal);
    }
}


