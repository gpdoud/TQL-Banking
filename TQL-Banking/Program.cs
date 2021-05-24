using System;

namespace TQL_Banking {
    class Program {
        static void Main(string[] args) {

            var cd1 = new CertificateOfDeposit(Amount: 1000, Months: 12);
            cd1.Deposit(1);
            cd1.Withdraw(1);
            cd1.WithdrawDate = DateTime.Now.AddDays(-1); // yesterday
            var funds = cd1.Withdraw();

            var sav1 = new Savings();
            sav1.Deposit(1000);
            sav1.PayInterest(3);

            var acct1 = new Account();
            acct1.Deposit(500);
            acct1.Withdraw(200);
            acct1.Withdraw(600);
            acct1.Deposit(-400);
            Console.WriteLine($"Balance is {acct1.Balance}");

            var acct2 = new Account();
            acct1.Transfer(1000, acct2);
            Console.WriteLine($"Balance is {acct1.Balance}");
            Console.WriteLine($"Balance is {acct2.Balance}");
        }
    }
}
