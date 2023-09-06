namespace VendingMachine.Exeption
{
    public class ProductAdditionFailedException : Exception
    {
        public ProductAdditionFailedException()
            : base() { }

        public ProductAdditionFailedException(string message)
            : base(message) { }

        public ProductAdditionFailedException(string message, Exception inner)
            : base(message, inner) { }
    }
}