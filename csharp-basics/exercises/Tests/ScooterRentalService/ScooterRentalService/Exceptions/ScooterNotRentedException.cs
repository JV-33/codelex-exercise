namespace ScooterRentalService.Exceptions
{
    public class ScooterNotRentedException : Exception
    {
        public ScooterNotRentedException(string message) : base(message)
        {
        }
    }

}

