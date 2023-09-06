namespace VendingMachine.Exeption
{
    public class InvalidProductNumberException : Exception
    {
        public InvalidProductNumberException()
            : base() { }

        public InvalidProductNumberException(string message)
            : base(message) { }

        public InvalidProductNumberException(string message, Exception inner)
            : base(message, inner) { }
    }
}