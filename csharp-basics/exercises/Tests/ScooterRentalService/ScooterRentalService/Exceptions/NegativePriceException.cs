using System;

namespace ScooterRentalService
{
    public class NegativePriceException : Exception
    {
        public NegativePriceException(string message = "Negative price provided.") : base(message)
        {
        }
    }
}