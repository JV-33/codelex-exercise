namespace VendingMachine.Exeption
{
    public class ProductAvailabilityExceededException : Exception
    {
        public ProductAvailabilityExceededException()
            : base() { }

        public ProductAvailabilityExceededException(string message)
            : base(message) { }

        public ProductAvailabilityExceededException(string message, Exception inner)
            : base(message, inner) { }
    }
}