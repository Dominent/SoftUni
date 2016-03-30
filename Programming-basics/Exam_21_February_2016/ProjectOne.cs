using System;

class ProjectOne
{
    static void Main()
    {
        decimal money = Convert.ToDecimal(Console.ReadLine());
        decimal rate = Convert.ToDecimal(Console.ReadLine());

        decimal pizzaPrice = Convert.ToDecimal(Console.ReadLine());
        decimal lasagnaPRice = Convert.ToDecimal(Console.ReadLine());
        decimal sandwichPrice = Convert.ToDecimal(Console.ReadLine());

        long pizzaQuantity = Convert.ToInt64(Console.ReadLine());
        long lasagnaQuantity = Convert.ToInt64(Console.ReadLine());
        long sandwichQuantity = Convert.ToInt64(Console.ReadLine());


        decimal sum = ((pizzaPrice/rate)*pizzaQuantity) +
                     ((lasagnaPRice/rate)*lasagnaQuantity) +
                     ((sandwichPrice/rate)*sandwichQuantity);

        if (sum < money)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.", money - sum);
        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.",sum - money);
        }
    }
}
 
