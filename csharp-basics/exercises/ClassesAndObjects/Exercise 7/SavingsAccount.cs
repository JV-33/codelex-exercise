using System;
namespace Exercise_7
{
    public class SavingsAccount
    {
        private double _annualInterestRate;
        private double _balance;
        private double _totalDeposits = 0;
        private double _totalWithdrawals = 0;
        private double _totalInterestEarned = 0;

        public SavingsAccount(double startingBalance)
        {
            _balance = startingBalance;
        }

        public double AnnualInterestRate
        {
            get { return _annualInterestRate; }
            set { _annualInterestRate = value; }
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            _totalDeposits += amount;
        }

        public void Withdraw(double amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                _totalWithdrawals += amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

        public void AddMonthlyInterest()
        {
            double monthlyInterest = (_balance * _annualInterestRate) / 12;
            _balance += monthlyInterest;
            _totalInterestEarned += monthlyInterest;
        }

        public double TotalDeposits => _totalDeposits;
        public double TotalWithdrawals => _totalWithdrawals;
        public double TotalInterestEarned => _totalInterestEarned;
        public double Balance => _balance;
    }
}
