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
            if (scooter != null)
            {
                _scooters.Remove(scooter);
            }
            else
            {
                throw new ScooterNotFoundException(id);
            }
        }

    }
}
