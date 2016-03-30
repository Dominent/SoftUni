using System;
using System.Collections.Generic;


class EncryptedMatrix
{
    static void Main()
    {
        string input = "?";
        char diagonal;
        input = Console.ReadLine();
        diagonal = Convert.ToChar(Console.ReadLine());

        char[] letters = new char[input.Length];
        letters = input.ToCharArray();
        int[] unicodeLetters = new int[input.Length];// list

        List<int> encryptedVals = new List<int>();

        int[] encryptedValues = new int[input.Length];

        for (int i = 0; i < input.Length; ++i)
        {
            for (char c = (char)32; c < (char)255; ++c)
            {
                if (letters[i] == c)
                {
                    unicodeLetters[i] = (int)c % 10;
                }
            }
        }

        for (int i = 0; i < unicodeLetters.Length; ++i)
        {
            if (unicodeLetters[i] % 2 == 0 || unicodeLetters[i] == 0)
            {
                bool exit = false;
                if (unicodeLetters[i] * unicodeLetters[i] > 9 || exit == true)
                {
                    string tempMatrix = (unicodeLetters[i] * unicodeLetters[i]).ToString();
                        char []tempCharArray= new char[tempMatrix.Length];
                        tempCharArray = tempMatrix.ToCharArray();
                    for (int k = 0; k < tempCharArray.Length; ++k)
                    {
                        encryptedVals.Add(tempCharArray[k] - 48); // hackfix - '48' --> 1
                    }
                    exit = true;
                }
                else
                {
                    encryptedVals.Add(unicodeLetters[i] * unicodeLetters[i]);
                }
            }
            else
            {
                encryptedVals.Add((i - 1 >= 0 ? unicodeLetters[i - 1] : 0) + unicodeLetters[i] + (i + 1 < input.Length ? unicodeLetters[i + 1] : 0));
            }
        }
        int[,] encryptedMatrix = new int[encryptedVals.Count, encryptedVals.Count];
        switch (diagonal)
        {
            case '\u002F': // '/'
                for (int x = 0, y = 0; x < encryptedVals.Count; ++x)
                {
                    encryptedMatrix[x, y] = encryptedVals[x];
                    if (y < encryptedVals.Count)
                    {
                        ++y;
                    }
                    else
                    {
                        break;
                    }
                }
                break;
            case '\u005C': // '\'
                for (int x = encryptedVals.Count - 1, y = 0; x >= 0; --x)
                {
                    encryptedMatrix[x, y] = encryptedVals[(encryptedVals.Count - 1) - x];
                    if (y < encryptedVals.Count)
                    {
                        ++y;
                    }
                    else
                    {
                        break;
                    }
                }
                break;
            default:
                break;
        }
        for (int x = 0; x < encryptedVals.Count; ++x)
        {
            for (int y = 0; y < encryptedVals.Count; ++y)
            {
                Console.Write("{0,3}", encryptedMatrix[x, y]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
