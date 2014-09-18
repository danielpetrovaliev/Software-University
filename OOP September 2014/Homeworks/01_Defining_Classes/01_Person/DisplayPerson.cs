using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DisplayPerson
{
    static void Main()
    {
        Person dani = new Person("Daniel", 19);
        Console.WriteLine(dani);
        Console.WriteLine();

        Person vili = new Person("Velicka", 19, "vuluto@gmail.com");
        Console.WriteLine(vili);
        Console.WriteLine();

        Person goshko = new Person("Goshko", 99, "hubaveca@goshko.qk");
        Console.WriteLine(goshko);

        //This will throw Exception
        Person gosho = new Person("Goshko", 56, "<script>alert(\"Zdrastiii\")</script>");
        Console.WriteLine(gosho);
    }
}
