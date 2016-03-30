using System;

class DigitAsWord
{
    static void Main()
    {
        uint input = 0;

        try
        {
            input = Convert.ToUInt32(Console.ReadLine());
            char temp = (char)(input + 96);
            Console.WriteLine(temp);
        }
        catch (FormatException)
        {
            Console.WriteLine("not a digit");
            throw;
        }
        catch (OverflowException)
        {
            Console.WriteLine("not a digit");
            throw;
        }
    }
}

