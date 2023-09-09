namespace VendingMachine.Exeption
{
    public class InvalidCentsValueException : Exception
    {
        private const string DefaultMessage = "Cents value should be between 0 and 99 inclusive.";

        public InvalidCentsValueException()
            : base(DefaultMessage) { }

        public InvalidCentsValueException(string message)
            : base(message) { }

        public InvalidCentsValueException(string message, Exception inner)
            : base(message, inner) { }
    }
}
