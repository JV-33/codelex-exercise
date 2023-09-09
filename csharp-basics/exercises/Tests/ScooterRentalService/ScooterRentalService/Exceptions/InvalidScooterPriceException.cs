namespace ScooterRentalService
{
    public class InvalidScooterPriceException : Exception
    {
        public InvalidScooterPriceException() : base() { }

        public InvalidScooterPriceException(string message) : base(message) { }

        public InvalidScooterPriceException(string message, Exception inner) : base(message, inner) { }
    }
}