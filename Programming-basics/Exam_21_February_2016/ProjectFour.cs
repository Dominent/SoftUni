using System;

class ProjectFour
{
    private static void Main()
    {
        decimal money = Convert.ToDecimal(Console.ReadLine());

        money = Math.Round(money, 2);

        if (money >= 0)
        {
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == "mall.Enter")
                {
                    string input = "";

                    bool isUsed = false;
                    bool goesShoping = false;

                    int count = 0;

                    while (true)
                    {
                        goesShoping = true;

                        input = Console.ReadLine();

                        if (input == "mall.Exit") break;

                        char[] tempChar = input.ToCharArray();

                        decimal price = 0;

                        foreach (var ch in tempChar)
                        {
                            if (ch >= 97 && ch <= 122) //lowercase
                            {
                                price = ((ch / 100m) * 30);
                                if (price <= money)
                                {
                                    money = money - price;
                                    isUsed = true;
                                    ++count;
                                }
                            }
                            else if (ch >= 65 && ch <= 90) //uppercase
                            {
                                price = ((ch / 100m) * 50);
                                if (price <= money)
                                {
                                    money = money - price;
                                    isUsed = true;
                                    ++count;
                                }
                            }
                            else if (ch == '%') // %
                            {
                                if (money == 0)
                                {

                                }
                                else
                                {
                                    ++count;
                                    money = money / 2;
                                    isUsed = true;
                                }
                            }
                            else if (ch == '*') // *
                            {
                                money += 10;
                            }
                            else
                            {
                                price = ch;
                                if (price <= money)
                                {
                                    money = money - ch;
                                    isUsed = true;
                                    ++count;
                                }
                            }
                        }
                    }
                    if (isUsed)
                    {
                        Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", count, money);
                    }
                    else if (isUsed == false && goesShoping == true)
                    {
                        Console.WriteLine("No purchases. Money left: {0:F2} lv.", money);
                    }
                    if (input == "mall.Exit") break;
                }
                // if (temp == "mall.Exit")
            }
        }
    }
}
