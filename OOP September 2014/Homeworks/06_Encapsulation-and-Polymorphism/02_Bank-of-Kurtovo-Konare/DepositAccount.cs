using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_of_Kurtovo_Konare
{
    public class DepositAccount : Account
    {
        public virtual void Withdraw(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "sum", "Sum should be posotive.");
            }

            if (this.Balance - sum < 0)
            {
                throw new InvalidOperationException(
                    "unsufficient balance.");
            }

            this.Balance -= sum;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }
    }
}
