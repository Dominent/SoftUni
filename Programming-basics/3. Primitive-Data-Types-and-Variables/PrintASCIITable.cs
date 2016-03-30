using System;
//using System.Text;
//https://softuni.bg/forum/155/homework-csharp-basics-problem-14-print-the-ascii-table

class PrintASCIITable
{
    static void Main()
    {
        //Console.OutputEncoding = Encoding.Unicode;
        //for (char c = (char)033; c <= (char)127; ++c)
        //{
        //    Console.WriteLine(c);
        //}
        //Console.OutputEncoding = Encoding.Unicode;
        //for (char c = (char)160; c <= (char)255; ++c)
        //{
        //    Console.WriteLine(c);
        //}
        for (char c = (char)0; c <= (char)255; ++c)
        {
            Console.WriteLine(c);
        }
    }
}
