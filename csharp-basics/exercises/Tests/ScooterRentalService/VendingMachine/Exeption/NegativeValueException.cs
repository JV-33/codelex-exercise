namespace VendingMachine.Exeption
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException()
            : base() { }

        public NegativeValueException(string message)
            : base(message) { }

        public NegativeValueException(string message, Exception inner)
            : base(message, inner) { }
    }
}