using System;

internal class NumberAsWords
{
    private static void Main()
    {
        int input = 0;
        int hundreds = 0;
        int decimals = 0;
        int ones = 0;


        for (int i = 0; i < 1; ++i)
        {
            try
            {
                Console.WriteLine("Enter a Number: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad Input.");
                --i;
            }
        }
        if (input <= 999 && input >= 0)
        {

            hundreds = input / 100;
            decimals = (input / 10) % 10;
            //
            if (input > 10)
                ones = input % 10;
            else
                ones = input;
            //
            switch (hundreds)
            {
                case 0:
                    break;
                case 1:
                    Console.Write("One hundred");
                    break;
                case 2:
                    Console.Write("Two hundred");
                    break;
                case 3:
                    Console.Write("Three hundred");
                    break;
                case 4:
                    Console.Write("Four hundred");
                    break;
                case 5:
                    Console.Write("Five hundred");
                    break;
                case 6:
                    Console.Write("Six hundred");
                    break;
                case 7:
                    Console.Write("Seven hundred");
                    break;
                case 8:
                    Console.Write("Eight hundred");
                    break;
                case 9:
                    Console.Write("Nine hundred");
                    break;
            }
            if ((decimals == 0) && (hundreds != 0))
            {
                switch (ones)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write(" and one");
                        break;
                    case 2:
                        Console.Write(" and two");
                        break;
                    case 3:
                        Console.Write(" and three");
                        break;
                    case 4:
                        Console.Write(" and four");
                        break;
                    case 5:
                        Console.Write(" and five");
                        break;
                    case 6:
                        Console.Write(" and six");
                        break;
                    case 7:
                        Console.Write(" and seven");
                        break;
                    case 8:
                        Console.Write(" and eight");
                        break;
                    case 9:
                        Console.Write(" and nine");
                        break;
                }
            }
            else
            {
                switch (decimals)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            switch (ones)
                            {
                                case 0:
                                    Console.WriteLine(" and ten");
                                    break;
                                case 1:
                                    Console.WriteLine(" and eleven");
                                    break;
                                case 2:
                                    Console.WriteLine(" and twelve");
                                    break;
                                case 3:
                                    Console.WriteLine(" and thirteen");
                                    break;
                                case 4:
                                    Console.WriteLine(" and fourteen");
                                    break;
                                case 5:
                                    Console.WriteLine(" and fifteen");
                                    break;
                                case 6:
                                    Console.WriteLine(" and sixteen");
                                    break;
                                case 7:
                                    Console.WriteLine(" and seventeen");
                                    break;
                                case 8:
                                    Console.WriteLine(" and eighteen");
                                    break;
                                case 9:
                                    Console.WriteLine(" and nineteen");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        {
                            if (ones != 0)
                            {
                                Console.Write(" and twenty");
                            }
                            else
                            {
                                Console.Write("Twenty ");
                            }

                        }
                        break;
                    case 3:
                        {
                            if (ones != 0)
                            {
                                Console.Write(" and thirty");
                            }
                            else
                            {
                                Console.Write("Thirty ");
                            }
                        }
                        break;
                    case 4:
                        {
                            if (ones != 0)
                            {
                                Console.Write(" and fourty");
                            }
                            else
                            {
                                Console.Write("Fourty ");
                            }
                        }
                        break;
                    case 5:
                        {
                            if (ones != 0)
                            {
                                Console.Write(" and fifty");
                            }
                            else
                            {
                                Console.Write("Fifty ");
                            }
                        }
                        break;
                    case 6:
                        {
                            if (ones != 0)
                            {
                                Console.Write(" and sixty");
                            }
                            else
                            {
                                Console.Write("Sixty ");
                            }
                        }
                        break;
                    case 7:
                        {
                            if (ones != 0)
                            {
                                Console.Write(" and seventy");
                            }
                            else
                            {
                                Console.Write("Seventy ");
                            }
                        }
                        break;
                    case 8:
                        {
                            if (ones != 0)
                            {
                                Console.Write(" and eighty");
                            }
                            else
                            {
                                Console.Write("Eighty ");
                            }
                        }
                        break;
                    case 9:
                        {
                            if (ones != 0)
                            {
                                Console.Write(" and ninety ");
                            }
                            else
                            {
                                Console.Write("Ninety ");
                            }
                        }
                        break;
                }

                if ((decimals != 0) && (hundreds != 0))
                {
                    switch (ones)
                    {
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.WriteLine("three");
                            break;
                        case 4:
                            Console.WriteLine("four");
                            break;
                        case 5:
                            Console.WriteLine("five");
                            break;
                        case 6:
                            Console.WriteLine("six");
                            break;
                        case 7:
                            Console.WriteLine("seven");
                            break;
                        case 8:
                            Console.WriteLine("eight");
                            break;
                        case 9:
                            Console.WriteLine("nine");
                            break;
                        default:
                            Console.WriteLine("zero");
                            break;
                    }
                }
                else
                {
                    switch (ones)
                    {
                        case 1:
                            Console.WriteLine("One");
                            break;
                        case 2:
                            Console.WriteLine("Two");
                            break;
                        case 3:
                            Console.WriteLine("Three");
                            break;
                        case 4:
                            Console.WriteLine("Four");
                            break;
                        case 5:
                            Console.WriteLine("Five");
                            break;
                        case 6:
                            Console.WriteLine("Six");
                            break;
                        case 7:
                            Console.WriteLine("Seven");
                            break;
                        case 8:
                            Console.WriteLine("Eight");
                            break;
                        case 9:
                            Console.WriteLine("Nine");
                            break;
                        default:
                            Console.WriteLine("Zero");
                            break;
                    }

                }
            }
        }
    }
}


