using System;


class Dumbbell
{
    static void Main()
    {
        int valN;
        int counter = 0;

        valN = Convert.ToInt32(Console.ReadLine());
        char[,] symbols;
        symbols = new char[valN, valN * 3];
        int start = valN / 2;

        for (int row = (start - 1); row >= 0; --row) // LeftUp
        {
            ++counter;
            for (int column = counter; column < valN; ++column)
            {
                if ((column > counter && column < valN - 1) && row != 0)
                {
                    symbols[row, column] = '*';
                }
                else
                {
                    symbols[row, column] = '&';
                }
            }
        }
        for (int column = 0; column < valN; ++column)  // LeftMiddle
        {
            if (column == 0 || column == valN - 1)
            {
                symbols[start, column] = '&';
            }
            else
            {
                symbols[start, column] = '*';
            }
        }
        counter = 0;
        for (int row = (start + 1); row < valN; ++row) // LeftDown
        {
            ++counter;
            for (int column = counter; column < valN; ++column)
            {
                if ((column > counter && column < valN - 1) && row != (valN) - 1)
                {
                    symbols[row, column] = '*';
                }
                else
                {
                    symbols[row, column] = '&';
                }
            }
        }
        counter = 0; 
        int offset = (valN * 3) - 1;
        for (int row = (start - 1); row >= 0; --row) // RightUp
        {
            ++counter;
            for (int column = offset - counter; column > valN * 2 - 1; --column)
            {
                if ((column < (offset - counter) && column > valN * 2) && row != 0)
                {
                    symbols[row, column] = '*';
                }
                else
                {
                    symbols[row, column] = '&';
                }
            }
        }
        for (int column = valN * 2; column < valN * 3; ++column) // RightMiddle
        {
            if (column == valN * 2 || column == valN * 3 - 1)
            {
                symbols[start, column] = '&';
            }
            else
            {
                symbols[start, column] = '*';
            }
        }
        counter = 0;
        for (int row = (start + 1); row < valN; ++row) //RightDown
        {
            ++counter;
            for (int column = offset - counter; column > valN * 2 - 1; --column)
            {
                if ((column < (offset - counter) && column > valN * 2) && row != valN - 1)
                {
                    symbols[row, column] = '*';
                }
                else
                {
                    symbols[row, column] = '&';
                }
            }
        }
        for (int y = valN; y < valN * 2; ++y) // MiddleMiddle
        {
            symbols[start, y] = '=';
        }

        for (int x = 0; x < valN; ++x) // Middle
        {
            for (int y = 0; y < valN * 3; ++y)
            {
                if (symbols[x, y] == '\0')
                {
                    symbols[x, y] = '.';
                }
                else
                {
                    continue;
                }
            }
        }
        for (int x = 0; x < valN; ++x)
        {
            for (int y = 0; y < valN * 3; ++y)
            {
                Console.Write("{0,1}", symbols[x, y]);
            }
            Console.WriteLine();
        }

    }
}

