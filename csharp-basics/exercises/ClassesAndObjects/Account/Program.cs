using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account firstAccount = new Account("My first account", 100.00);
            firstAccount.Deposit(20);
            Console.WriteLine(firstAccount);

            Account matt = new Account("Matt's account", 1000.00);
            matt.Withdrawal(100.00);
            Account myAccount = new Account("My account", 0.00);
            myAccount.Deposit(100.00);
            Console.WriteLine(matt);
            Console.WriteLine(myAccount);

            Account A = new Account("A account", 100.00);
            Account B = new Account("B account", 0.00);
            Account C = new Account("C account", 0.00);

            Account.Transfer(A, B, 50.00);
            Console.WriteLine(A);
            Console.WriteLine(B);

            Account.Transfer(B, C, 25.00);
            Console.WriteLine(B);
            Console.WriteLine(C);

            Console.ReadKey();


        }
    }
}
