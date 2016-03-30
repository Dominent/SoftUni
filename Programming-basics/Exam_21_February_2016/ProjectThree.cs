using System;

class ProjectThree
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("##{0}##{1}##",new string('.', valN * 2), new string('.', valN * 2));
        for (int i = 1, j = ((valN - 1) * 2), k = 2; i < valN; i++, j = j - 2, k = k + 2) // hmm 0 or 1
        {
            Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', i) , new string('.',j), new string('.', k)); //#{1}#{2}#{3}#{4}#
        }
        Console.WriteLine(".#{0}#{1}#{0}#.", new string('~', valN), new string('.', valN* 2));
        for (int i = 1, j = 3, k = valN - 1, z = valN * 2 - 2; i < valN; i++ , j = j + 2, --k, z = z -2) // here j is hardcoded !
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', j), new string('~', k), new string('.', z));
        }
        Console.WriteLine("{0}####{1}", new string('.', valN * 2 + 1), new string('.', valN * 2 + 1));
        for (int i = 0; i < valN; i++)
        {
            Console.WriteLine("{0}##{1}", new string('.', valN * 2 + 2), new string('.', valN * 2 + 2));
        }

    }
}

