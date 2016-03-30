using System;

class ProjectFive
{
    static void Main()
    {
        ulong val = Convert.ToUInt64(Console.ReadLine());
        ulong mask = 1;
        while (true)
        {
            string input = Console.ReadLine();
            if(input == "end")break;
            string[] temp = input.Split();
            int bla = Convert.ToInt32(temp[1]); // But Why ?

            if (temp[0] == "salt")
            {
                for (int i = 0; i < 64; i = i + bla)
                {
                    if ((val & (mask << i)) > 0) val = val & ~(mask << i);
                }
            }
            if (temp[0] == "pepper")
            {
                for (int i = 0; i < 64; i = i + bla)
                {
                    if ((val & (mask << i)) == 0) val = val | (mask << i); 
                }
            }
        }
        Console.WriteLine(val);
    }
}

