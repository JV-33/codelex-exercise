using System;

namespace Account
{
    class Account
    {
        private double _balance;
        private string _name;
        
        

        public double Balance  => _balance;
        public string Name => _name; 
        

        public  Account(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public void Withdrawal(double withdrawal)
        {
            if (_balance >= withdrawal)
            {
                _balance -= withdrawal;
            }
            else
            {
                Console.WriteLine("Kontā nepietiek līdzekļi");
            }
            
        }

        public override string ToString()
        {
            return $"{_name}: {_balance}";
        }


        public void Deposit(double deposit)
        {
            _balance += deposit;
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }

        public double GetBalance()
        {
            return _balance;
        }
        
    }
}
