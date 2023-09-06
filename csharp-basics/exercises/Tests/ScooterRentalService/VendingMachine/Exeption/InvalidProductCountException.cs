namespace VendingMachine.Exeption
{

    public class InvalidProductCountException : Exception
    {
        public InvalidProductCountException() { }

        public InvalidProductCountException(string message)
            : base(message) { }

        public InvalidProductCountException(string message, Exception inner)
            : base(message, inner) { }
    }
}