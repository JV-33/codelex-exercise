namespace VendingMachine
{
    public class NegativeAmountException : Exception
    {
        public NegativeAmountException()
            : base("Amount should not be negative.")
        { }
    }
}

