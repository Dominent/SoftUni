using System;

class Rectangle
{
    static void Main()
    {
        int width = 0;
        int height = 0;

        width = Convert.ToInt32(Console.ReadLine());
        height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Area: {0}\nPerimeter: {1}", (width * height), (width + height)*2);
    }
}

