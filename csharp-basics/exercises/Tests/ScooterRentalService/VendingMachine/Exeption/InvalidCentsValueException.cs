namespace VendingMachine
{
    public class InvalidCentsValueException : Exception
    {
        public InvalidCentsValueException()
            : base("Cents should be between 0 and 99.")
        { }
    }
}

