namespace ScooterRentalService
{
    public class ScooterNotFoundException : Exception
    {
        public ScooterNotFoundException() : base() { }

        public ScooterNotFoundException(string id)
            : base($"Scooter with ID {id} not found.") { }
    }

}

