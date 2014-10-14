using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bank_of_Kurtovo_Konare
{
    public class LoanAccount : Account
    {
        public override decimal CalculateInterest(int months)
        {
            int monthsNoInterest = 0;
            if (this.Customer is IndividualCustomer)
            {
                monthsNoInterest = 3;
            }

            if (this.Customer is CompanyCustomer)
            {
                monthsNoInterest = 2;
            }

            if (months <= monthsNoInterest)
            {
                return 0;
            }

            decimal interestForPeriod =
                base.CalculateInterest(months - monthsNoInterest);
            return interestForPeriod;
        }
    }
}
