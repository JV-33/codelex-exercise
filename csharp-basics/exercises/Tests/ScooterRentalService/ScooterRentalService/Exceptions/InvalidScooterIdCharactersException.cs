using System;
namespace ScooterRentalService.Exceptions
{
    public class InvalidScooterIdCharactersException : Exception
    {
        public InvalidScooterIdCharactersException() : base("Scooter ID contains invalid characters.") { }
    }
}

