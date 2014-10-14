using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_of_Kurtovo_Konare
{
    public abstract class Account
    {
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal MonthlyInterestRate { get; set; }

        public virtual void Deposit(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "sum", "Sum should be posotive.");
            }
            this.Balance += sum;
        }

        public virtual decimal CalculateInterest(int mounths)
        {
            decimal interest = 
                this.Balance * (this.MonthlyInterestRate * mounths) / 12;
            return interest;
        }

    }
}
