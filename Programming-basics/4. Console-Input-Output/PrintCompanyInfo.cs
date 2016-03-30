using System;

class PrintCompanyInfo
{
    static void Main()
    {
        string companyName = "?";
        string companyAddress = "?";
        string phoneNumber = "?";
        string faxNumber = "?";
        string website = "?";
        string managerFirstName = "?";
        string managerLastName = "?";
        byte managerAge = 0;
        string managerPhone = "?";

        companyName = Console.ReadLine();
        companyAddress = Console.ReadLine();
        phoneNumber = Console.ReadLine();
        faxNumber = Console.ReadLine();
        website = Console.ReadLine();
        managerFirstName = Console.ReadLine();
        managerLastName = Console.ReadLine();
        managerAge = Convert.ToByte(Console.ReadLine());
        managerPhone = Console.ReadLine();

        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", string.IsNullOrEmpty(faxNumber)? "(No Fax)":faxNumber);
        Console.WriteLine("Web site: {0}", website);
        Console.Write("Manager: {0} {1}  (age: {2}, tel. {3})", managerFirstName, managerLastName,managerAge, managerPhone);
        Console.WriteLine();
    }
}

