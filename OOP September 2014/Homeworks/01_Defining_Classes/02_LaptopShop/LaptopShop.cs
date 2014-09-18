using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LaptopShop
{
    
    static void Main()
    {
        Laptop lenovoYoga2Pro = new Laptop(
            model: "Lenovo Yoga 2 Pro",
            manufacturer:"Lenovo",
            processor: "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 
            graphicsCard:"Intel HD Graphics 4400",
            ram: 8,
            battery: "4 kletachna",
            batteryLife: 4,
            screen: "13.3 inch",
            price: 2259.0m
            );


        Console.WriteLine(lenovoYoga2Pro);
        Console.WriteLine();

        Laptop lenovo = new Laptop(
            model: "Lenovo Yoga 2 Pro",
            manufacturer: "Lenovo",
            processor: "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
            graphicsCard: "Intel HD Graphics 4400",
            ram: 8,
            batteryLife: 8,
            screen: "13.3 inch",
            price: 2259.0m
            );
        Console.WriteLine(lenovo);
        Console.WriteLine();

        Laptop asus = new Laptop("Asus 1234511234", (decimal)5000);
        Console.WriteLine(asus);


    }
}


//class SampleClass
//{
//    public string MyRequiredField
//    {
//        get;
//        set
//        {
//            if (String.IsNullOrEmpty(value))
//                throw new ArgumentNullException;
//        }
//    }

//    public string MyOptionalField
//    {
//        get;
//        set
//        {
//            if (String.IsNullOrEmpty(value))
//                throw new AgrumentNullException;
//        }
//    }

//    public SampleClass(string required, string optional = null)
//    {
//        this.MyRequiredField = required;

//        if (optional)
//        {
//            this.MyOptionalField = optional;
//        }
//    }
//}