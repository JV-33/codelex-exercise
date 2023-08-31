namespace ScooterRentalService
{
    public class ScooterService : IScooterService
    {
        private List<Scooter> _scooters;

        public ScooterService()
        {
            _scooters = new List<Scooter>();
        }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            var scooter = new Scooter(id, pricePerMinute);
            _scooters.Add(scooter);
        }

        public Scooter GetScooterById(string scooterId)
        {
            return _scooters.FirstOrDefault(s => s.Id == scooterId);
        }

        public IList<Scooter> GetScooters()
        {
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
                throw new Exception($"Scooter with ID {id} not found.");
            }
        }
    }
}
