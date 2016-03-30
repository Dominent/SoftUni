using System;

class BeerTime
{
    static void Main()
    {
        string[] dateTime;

        string temp = Console.ReadLine(); //hh:mm tt

        dateTime = temp.Split();

        string[] stfu = dateTime[0].Split(':'); //me and my naming

        if ((Convert.ToInt32(stfu[0])) > 0 && (Convert.ToInt32(stfu[1])) < 60)
        {
            if (((dateTime[1] == "PM" && Convert.ToInt32(stfu[0]) < 12) && ((Convert.ToInt32(stfu[1])) < 60)) ||
                ((dateTime[1] == "AM" && Convert.ToInt32(stfu[0]) < 3) && ((Convert.ToInt32(stfu[1])) < 60)))
            {
                Console.WriteLine("Beer Time");
            }
            else
            {
                Console.WriteLine("non-beer Time");
            }
        }
    }
}

