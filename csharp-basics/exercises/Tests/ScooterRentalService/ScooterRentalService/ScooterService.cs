namespace ScooterRentalService
{
    public class ScooterService : IScooterService
    {
        private readonly List<Scooter> _scooters;

        public ScooterService()
        {
            _scooters = new List<Scooter>();
        }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id), "Id cannot be null or empty.");
            }
            if (pricePerMinute <= 0)
            {
                throw new InvalidScooterPriceException("Price per minute cannot be negative or zero.");
            }
            if (_scooters.Any(s => s.Id == id))
            {
                throw new DuplicateScooterException();
            }

            var scooter = new Scooter(id, pricePerMinute);
            _scooters.Add(scooter);
        }

        public Scooter GetScooterById(string scooterId)
        {
            var scooter = _scooters.FirstOrDefault(s => s.Id == scooterId);
            if (scooter == null)
            {
                throw new ScooterNotFoundException(scooterId);
            }
            return scooter;
        }

        public IList<Scooter> GetScooters()
        {
            if (!_scooters.Any())
            {
                throw new NoScootersAvailableException();
            }
            return _scooters;
        }

        public void RemoveScooter(string id)
        {
            var scooter = GetScooterById(id);
            if (scooter.IsRented)
            {
                throw new InvalidOperationException("Cannot remove a scooter that is currently being rented.");
            }

            _scooters.Remove(scooter);
        }
    }
}