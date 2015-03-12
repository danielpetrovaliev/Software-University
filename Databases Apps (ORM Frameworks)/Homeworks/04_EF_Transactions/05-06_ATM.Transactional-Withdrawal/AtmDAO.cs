using System;
using System.Linq;
using _05_ATM.Data_Models;

namespace _05_ATM.Transactional_Withdrawal
{
    public static class AtmDAO
    {
        // Problem 5.	Transactional ATM Withdrawal
        public static void WithdrawMoney(decimal amount, string cardPin, string cardNumber)
        {
            using (var atmEntities = new ATMEntities())
            {
                using (var transaction = atmEntities.Database.BeginTransaction())
                {
                    var currentCard = atmEntities.CardAccounts
                        .FirstOrDefault(c => c.CardNumber == cardNumber && c.CardPIN == cardPin);

                    if (currentCard == null)
                    {
                        transaction.Rollback();
                        throw new ArgumentNullException("There are no Card Account in database with this Pin and card number.");
                    }

                    if (currentCard.CardCash < amount)
                    {
                        transaction.Rollback();
                        throw new InvalidOperationException("You dont have enought money.");
                    }

                    currentCard.CardCash -= amount;

                    LogWithdrawalTransaction(cardNumber, amount);

                    atmEntities.SaveChanges();
                    transaction.Commit();

                    Console.WriteLine("Transaction completed.");
                }
            }
        }

        // Problem 6.	ATM Transactions History
        private static void LogWithdrawalTransaction(string cardNumber, decimal amount)
        {
            using (var atmEntities = new ATMEntities())
            {
                atmEntities.TransactionHistories.Add(new TransactionHistory
                {
                    Amount = amount,
                    CardNumber = cardNumber,
                    TransactionDate = DateTime.Now
                });

                atmEntities.SaveChanges();
            }
        }
    }
}