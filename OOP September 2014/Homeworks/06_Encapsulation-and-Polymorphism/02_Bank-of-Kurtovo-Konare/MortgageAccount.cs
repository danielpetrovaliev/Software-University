using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_of_Kurtovo_Konare
{
    public class MortgageAccount : Account
    {
        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months >= 6)
                {
                    return base.CalculateInterest(months - 6);
                }
                else
                {
                    return this.Balance;
                }
            }

            if (this.Customer is CompanyCustomer)
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months) / 2;
                }
                else
                {
                    return (base.CalculateInterest(12) / 2) + base.CalculateInterest(months - 12);
                }
            }

            return base.CalculateInterest(months);
        }
    }
}
