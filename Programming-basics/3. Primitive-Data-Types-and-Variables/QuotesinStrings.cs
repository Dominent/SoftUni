using System;

class QuotesinStrings
{
    static void Main()
    {
        string val1 = "The \"use\" of quotations causes difficulties.";
        string val2 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(val1);
        Console.WriteLine(val2);
    }
}

