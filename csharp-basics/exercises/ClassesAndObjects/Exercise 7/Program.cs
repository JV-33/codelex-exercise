namespace Exercise_7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How much money is in the account?: ");
        double startingBalance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the annual interest rate:");
        double annualInterestRate = Convert.ToDouble(Console.ReadLine()) / 100;

        SavingsAccount account = new SavingsAccount(startingBalance)
        {
            AnnualInterestRate = annualInterestRate
        };

        Console.Write("How long has the account been opened? ");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= months; i++)
        {
            Console.Write($"Enter amount deposited for month: {i}: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            account.Deposit(deposit);

            Console.Write($"Enter amount withdrawn for {i}: ");
            double withdrawal = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(withdrawal);

            account.AddMonthlyInterest();
        }

        Console.WriteLine($"Total deposited: ${account.TotalDeposits:0.00}");
        Console.WriteLine($"Total withdrawn: ${account.TotalWithdrawals:0.00}");
        Console.WriteLine($"Interest earned: ${account.TotalInterestEarned:0.00}");
        Console.WriteLine($"Ending balance: ${account.Balance:0.00}");
        Console.ReadKey();
    }
}

