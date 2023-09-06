namespace VendingMachine.Exeption
{
    public class InvalidProductNameException : Exception
    {
        public InvalidProductNameException() { }

        public InvalidProductNameException(string message)
            : base(message) { }

        public InvalidProductNameException(string message, Exception inner)
            : base(message, inner) { }
    }
}

