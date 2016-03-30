using System;

class FormattingNumbers
{
    static void Main()
    {
        int valA = 0;

        for (int i = 0; i < 1; ++i)
        {
            valA = Convert.ToInt32(Console.ReadLine());
            if (!(valA >= 0 && valA <= 500))
            {
                valA = 0;
                --i;
            }
        }
        float valB = 0;
        float valC = 0;

        valB = float.Parse(Console.ReadLine());
        valC = float.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}", valA);
        Console.Write("|{0}|", Convert.ToString(valA, 2).PadLeft(10, '0'));
        Console.Write("{0,10:F1}|{1,-10:F3}|", valB, valC);
        Console.WriteLine();
    }
}

