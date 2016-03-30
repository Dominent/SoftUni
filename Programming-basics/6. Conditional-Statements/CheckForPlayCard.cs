
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string[] chArr = new string[] { "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        string input = "?";
        bool isCard = false;

        input = Console.ReadLine();

        foreach (var val in chArr)
        {
            if (input == val)
            {
                isCard = true;
                break;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine(isCard);
    }
}

