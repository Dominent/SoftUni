using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime birthDay;

        Console.WriteLine("Enter Birth Date(12.04.1991): ");
        birthDay = Convert.ToDateTime(Console.ReadLine());

        int ageNow = DateTime.Now.Year - birthDay.Year;

        Console.WriteLine("Age now: {0}", ageNow);
        Console.WriteLine("Age after 10 years: {0}", ageNow + 10);
    }
}

