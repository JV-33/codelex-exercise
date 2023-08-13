using System;

namespace BankAccount
{
    class Program
    {

        private string _accountName;
        private decimal _balance;
        
        public Program(string accout, decimal balance)
        {
            _accountName = accout;
            _balance = balance;
        }

        static void Main(string[] args)
        {
            Program benben = new Program("Benson", -17.25m); 
            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.ReadKey();
        }

        public string ShowUserNameAndBalance()
        {
            decimal absBalance = Math.Abs(_balance);
            string formattedBalance = absBalance.ToString("$0.00");
            return $"{_accountName}, {formattedBalance}";
        }


    }
}
