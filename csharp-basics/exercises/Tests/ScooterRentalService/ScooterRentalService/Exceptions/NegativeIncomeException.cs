namespace ScooterRentalService
{
    public class NegativeIncomeException : Exception
    {
        public NegativeIncomeException()
            : base("The calculated income cannot be negative.") { }
    }
}
