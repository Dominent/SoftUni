using System;

class StringsAndObjects
{
    static void Main()
    {
        string val1 = "Hello";
        string val2 = "World";
        object val3 = val1 + " " + val2;
        string val4 = (string)val3;
    }
}

