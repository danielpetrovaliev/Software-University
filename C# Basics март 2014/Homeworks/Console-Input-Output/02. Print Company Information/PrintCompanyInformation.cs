using System;


class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string name = Console.ReadLine();
        Console.Write("Company adress: ");
        string adress = Console.ReadLine();
        Console.Write("Phone number: ");
        string CompanyNumber = Console.ReadLine();
        
        Console.Write("Fax number: ");
        string fax = Console.ReadLine();
        Console.Write("Web site: ");
        string site = Console.ReadLine();
        Console.Write("Maneger first name: ");
        string fname = Console.ReadLine();
        Console.Write("Maneger last name: ");
        string lname = Console.ReadLine();
        Console.Write("Maneger age: ");
        string age = Console.ReadLine();
        Console.Write("Maneger phone: ");
        string ManegerNumber = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(name);
        Console.WriteLine("Adress: {0}",adress);
        Console.WriteLine("Tel. {0}",CompanyNumber);
        if (fax == "")
        {
            Console.WriteLine("Fax: (no fax)");
        }
        Console.WriteLine("Web site: ",site);
        Console.WriteLine("Maneger: {0} {1} (age: \n{2}, tel. {3})",fname,lname,age,ManegerNumber);

    }
}
