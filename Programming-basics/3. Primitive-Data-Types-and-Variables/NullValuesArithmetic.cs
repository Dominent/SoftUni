using System;


class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? val1;
        double? val2;

        //Console.WriteLine(val1); --> use of unassigned local variable
        //Console.WriteLine(val2); --> use of unassigned local variable

        //val1 += 10; --> use of unassigned local variable
        //val2 += 20; --> use of unassigned local variable

        //Console.WriteLine(val1); --> use of unassigned local variable
        //Console.WriteLine(val2); --> use of unassigned local variable

        //val1 += null; --> use of unassigned local variable && the result of this expression is always 'null' of type 'int?'
        //val2 += null; --> use of unassigned local variable && the result of this expression is always 'null' of type 'int?'

        //Console.WriteLine(val1); --> use of unassigned local variable
        //Console.WriteLine(val2); --> use of unassigned local variable

    }
}

