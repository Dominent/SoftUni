using System;
using System.Diagnostics.CodeAnalysis;

class ZeroSubset
{
    static bool IsZero(int val1, int val2)
    {
        if ((val1 + val2) == 0)
            return true;
        else
            return false;
    }

    static void Main()
    {
        int count = 0;
        int sum = 0;
        int startPos = 0;

        int[] numArr = new int[5];

        //Input
        for (int i = 0; i < numArr.Length; ++i)
        {
            numArr[i] = Convert.ToInt32(Console.ReadLine());
        }


        for (int i = 0; i < numArr.Length; ++i)
        {
            for (int j = i; j < numArr.Length; j++)
            {
                if (sum != 0) // min two numbers
                {
                    if (count == 0)
                    {
                        startPos = 0;
                    }
                    sum += numArr[j];
                    ++count;
                }
                else
                {
                    // if(count >= 1)

                    for (int k = startPos; k < count + startPos; k++)
                    {
                        Console.WriteLine("{0} {1}", k, numArr[k]);
                    }
                    startPos = 0;

                }

            }
            sum = 0;
        }

        //Logic
        //for (int i = 0; i < numArr.Length; ++i)
        //{
        //    sum = numArr[i];
        //    count = numArr.Length;
        //    for (int k = i + 1; k < numArr.Length; ++k)
        //    {
        //        sum = sum + numArr[k];
        //        --count;
        //        //if (IsZero(numArr[i] + nextVal, numArr[k]))
        //        //{
        //        //    ++count;
        //        //    nextVal = numArr[i];
        //        //}
        //        //else
        //        //{
        //        //    if (count > 1)
        //        //    {
        //        //        Console.Write("{0} ", numArr[i]);
        //        //        for (int j = k; j < k + count; ++j)
        //        //        {
        //        //            Console.Write("{0} ", numArr[j]);
        //        //        }
        //        //        Console.WriteLine();
        //        //    }
        //        //    count = 0;
        //        //    nextVal = 0;

        //        //}
        //    }
        //    if (sum == 0)
        //    {
        //        for (int j = count; j < numArr.Length; ++i)
        //        {

        //        }
        //    }
        //}

    }
}

