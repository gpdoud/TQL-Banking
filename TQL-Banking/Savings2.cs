using System;
using System.Collections.Generic;
using System.Text;

namespace TQL_Banking {
    class Savings2 {

        private Account account = new Account();
        public decimal InterestRate { get; private set; } = 0.12m;

        public decimal CalculateInterestByMonths(int NumberOfMonths) {
            return account.Balance * (InterestRate / 12.0m) * NumberOfMonths;
        }

        public void PayInterest(int NumberOfMonths) {
            var interest = CalculateInterestByMonths(NumberOfMonths);
            Deposit(interest);
        }
        public bool Deposit(decimal amount) {
            return account.Deposit(amount);
        }
        public bool Withdraw(decimal amount) {
            return account.Withdraw(amount);
        }
        public bool Transfer(decimal amount, Account toAccount) {
            return account.Transfer(amount, toAccount);
        }

        public Savings2() {
            account = new Account();
        }
    }
}
