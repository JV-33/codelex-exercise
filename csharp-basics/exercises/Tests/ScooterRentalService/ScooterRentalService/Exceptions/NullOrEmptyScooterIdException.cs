using System;
namespace ScooterRentalService.Exceptions
{
    public class NullOrEmptyScooterIdException : Exception
    {
        public NullOrEmptyScooterIdException() : base("Scooter ID cannot be null or empty.") { }
    }

}

