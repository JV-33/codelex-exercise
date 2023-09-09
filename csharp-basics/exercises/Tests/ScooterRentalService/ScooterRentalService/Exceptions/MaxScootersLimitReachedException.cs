using System;
namespace ScooterRentalService.Exceptions
{
    public class MaxScootersLimitReachedException : Exception
    {
        public MaxScootersLimitReachedException() : base("Maximum number of scooters has been reached.") { }
    }

}

