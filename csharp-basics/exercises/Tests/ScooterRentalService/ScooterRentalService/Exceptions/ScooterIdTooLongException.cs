using System;
namespace ScooterRentalService.Exceptions
{
    public class ScooterIdTooLongException : Exception
    {
        public ScooterIdTooLongException(int maxLength) : base($"Scooter ID exceeds the maximum allowed length of {maxLength}.") { }
    }

}

