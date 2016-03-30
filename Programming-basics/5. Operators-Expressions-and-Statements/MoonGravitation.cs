using System;

class MoonGravitation
{
    static void Main()
    {
        float weight = 0f;

        weight = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Weight on the moon: {0}", weight * 0.17);
    }
}

