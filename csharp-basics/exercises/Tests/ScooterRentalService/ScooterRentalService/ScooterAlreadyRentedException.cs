namespace ScooterRentalService
{
    public class ScooterAlreadyRentedException : Exception
    {
        public ScooterAlreadyRentedException(string id)
            : base($"Scooter with ID {id} is already rented.") { }
    }
}