namespace VendingMachine.Exeption
{
    public class InvalidCoinException : Exception
    {
        public InvalidCoinException()
            : base() { }

        public InvalidCoinException(string message)
            : base(message) { }

        public InvalidCoinException(string message, Exception inner)
            : base(message, inner) { }
    }
}