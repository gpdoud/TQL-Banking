using System;

namespace TQL_Banking {
    class Program {
        static void Main(string[] args) {

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
