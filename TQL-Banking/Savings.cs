using System;
using System.Collections.Generic;
using System.Text;

namespace TQL_Banking {
    class Savings : Account {

        public decimal InterestRate { get; private set; } = 0.12m;

        public decimal CalculateInterestByMonths(int NumberOfMonths) {
            return Balance * (InterestRate / 12.0m) * NumberOfMonths;
        }

        public void PayInterest(int NumberOfMonths) {
            var interest = CalculateInterestByMonths(NumberOfMonths);
            Deposit(interest);
        }
    }
}
