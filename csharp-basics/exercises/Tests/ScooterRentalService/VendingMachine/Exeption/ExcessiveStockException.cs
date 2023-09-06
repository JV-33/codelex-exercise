namespace VendingMachine.Exeption
{
    public class ExcessiveStockException : Exception
    {
        public ExcessiveStockException()
            : base() { }

        public ExcessiveStockException(string message)
            : base(message) { }

        public ExcessiveStockException(string message, Exception inner)
            : base(message, inner) { }
    }
}