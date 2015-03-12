using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05_ATM.Data_Models;
using _05_ATM.Transactional_Withdrawal;

namespace _07_Unit_tests_ATM
{
    [TestClass]
    public class ATMTests
    {
        private const decimal Amount = 500.0m;
        private const decimal AmountBiggerThanCash = 100000.0m;
        private string newCardNumber;
        private CardAccount newCardAccount;

        [TestInitialize]
        public void TestInitialize()
        {
            this.newCardNumber = new Random().Next(1, 999999999).ToString();
            this.newCardAccount = new CardAccount {CardCash = 10000, CardNumber = newCardNumber, CardPIN = "4321"};

            using (var atmEntities = new ATMEntities())
            {
                atmEntities.CardAccounts.Add(newCardAccount);
                atmEntities.SaveChanges();
            }
        }

        [TestMethod]
        public void ShouldWithdrawalSumFromAccountAndAddTransactionHistoryForThem()
        {
            using (var atmEntities = new ATMEntities())
            {
                AtmDAO.WithdrawMoney(Amount, newCardAccount.CardPIN, newCardAccount.CardNumber);
            }

            using (var atmEntities = new ATMEntities())
            {
                var modifiedCardAccount =
                    atmEntities.CardAccounts.FirstOrDefault(c => c.CardNumber == newCardNumber);

                var historyForWithdrawal =
                    atmEntities.TransactionHistories.FirstOrDefault(h => h.CardNumber == newCardAccount.CardNumber);

                Assert.AreEqual(modifiedCardAccount.CardCash, newCardAccount.CardCash - Amount);
                Assert.AreEqual(modifiedCardAccount.CardNumber, newCardAccount.CardNumber);
                Assert.AreEqual(modifiedCardAccount.CardPIN, newCardAccount.CardPIN);

                Assert.AreEqual(historyForWithdrawal.Amount, Amount);
                Assert.AreEqual(historyForWithdrawal.CardNumber, newCardAccount.CardNumber);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "You dont have enought money.")]
        public void ShouldTryToWithdrawalAmountBiggerThanCash()
        {
            using (var atmEntities = new ATMEntities())
            {
                var atmAccount = atmEntities.CardAccounts.FirstOrDefault(a => a.CardNumber == newCardAccount.CardNumber);

                AtmDAO.WithdrawMoney(AmountBiggerThanCash, newCardAccount.CardPIN, newCardAccount.CardNumber);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "There are no Card Account in database with this Pin and card number.")]
        public void ShouldTryToWithdrawalAmountForWrongCardNumberAndPin()
        {
            using (var atmEntities = new ATMEntities())
            {
                var atmAccount = atmEntities.CardAccounts.FirstOrDefault(a => a.CardNumber == newCardAccount.CardNumber);

                AtmDAO.WithdrawMoney(AmountBiggerThanCash, "123", "32221145");
            }
        }
    }
}
