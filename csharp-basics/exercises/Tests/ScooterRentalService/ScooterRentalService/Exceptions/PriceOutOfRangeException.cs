using System;
namespace ScooterRentalService.Exceptions
{
    public class PriceOutOfRangeException : Exception
    {
        public PriceOutOfRangeException() : base("Price is out of the allowed range.") { }
    }
}

