using System;
using System.Linq;
using _05_ATM.Data_Models;

namespace _05_ATM.Transactional_Withdrawal
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmDAO.WithdrawMoney(500, "1234", "7894789512");

            // This will fail
            // WithdrawMoney(500, "1111", "7894787426");
        }

        
    }
}
