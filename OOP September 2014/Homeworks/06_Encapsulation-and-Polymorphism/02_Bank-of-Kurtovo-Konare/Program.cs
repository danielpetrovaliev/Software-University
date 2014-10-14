using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_of_Kurtovo_Konare
{
    class Program
    {
        static void Main(string[] args)
        {
            Account nakov = new DepositAccount()
            {
                Balance = 20000,
                Customer = new IndividualCustomer() { Name = "Nakov" },
                MonthlyInterestRate = 0.076m
            };

            decimal nakovInterest = nakov.CalculateInterest(24);
            Console.WriteLine(nakovInterest);

            Account mortgageNakovAcc = new MortgageAccount()
            {
                Balance = 2300000,
                Customer = new CompanyCustomer() { Name = "SoftUni" },
                MonthlyInterestRate = 0.086m
            };

            decimal mortageInterest = mortgageNakovAcc.CalculateInterest(4);
            Console.WriteLine(mortageInterest);
        }
    }
}
