using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Customer
{
    public class TestCustomers
    {
        static void Main(string[] args)
        {
            List<Payment> payments = new List<Payment>()
            {
                new Payment("Laptop", 999),
                new Payment("Glasses", 300),
                new Payment("Vodka", 60)
            }; 

            Customer pesho = new Customer("Pesho", "Peshev", "Peshov", "6840562897",
                "Karlukovo", "+3598888888888", "pesho+gosho@gay.com", payments, CustomerType.Golden);

            Customer gosho = new Customer("Gosho", "Georgiev", "Goshev", "5068795469", 
                "Gorna Orqhovica", "+359878967458", "gosho+pesho@gay.com", payments, CustomerType.Diamond);

            Console.WriteLine(pesho.CompareTo(gosho));
            Console.WriteLine(pesho.Equals(gosho));
            
            Console.WriteLine();
            Console.WriteLine(pesho);
            Console.WriteLine(pesho.GetHashCode());

            object clonedCustomer = gosho.Clone();
            Console.WriteLine(clonedCustomer.Equals(gosho));


        }
    }
}
