using System;

class PlayIntDoubleOrString
{
    static void Main()
    {
        int input = 0;
        int valInt = 0;
        double valDoub = 0.0d;
        string valStr = "?";


        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2-- > double");
        Console.WriteLine("3-- > string");
        input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {

            case 1:
                {
                    Console.WriteLine("Please enter a int:");
                    valInt = Convert.ToInt32(Console.ReadLine()) + 1;
                    Console.WriteLine(valInt);
                }
                break;
            case 2:
                {
                    Console.WriteLine("Please enter a double:");
                    valDoub = (Convert.ToDouble(Console.ReadLine()) + 1);
                    Console.WriteLine(valDoub);
                }
                break;
            case 3:
                {
                    Console.WriteLine("Please enter a string:");
                    valStr = Console.ReadLine() + "*";
                    Console.WriteLine(valStr);
                }
                break;
            default:
                break;
        }
    }
}

