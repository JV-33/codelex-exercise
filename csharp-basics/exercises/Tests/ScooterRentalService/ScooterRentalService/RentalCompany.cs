namespace ScooterRentalService
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        private readonly ITimeProvider _timeProvider;
        private readonly Dictionary<string, DateTime> _rentalStartTimes;

        public string Name { get; private set; }

        public RentalCompany(IScooterService scooterService, ITimeProvider timeProvider, string companyName)
        {
            _scooterService = scooterService ?? throw new ArgumentNullException(nameof(scooterService));
            _timeProvider = timeProvider ?? throw new ArgumentNullException(nameof(timeProvider));
            _rentalStartTimes = new Dictionary<string, DateTime>();
            Name = companyName ?? throw new ArgumentNullException(nameof(companyName));
        }

        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            if (scooter == null)
                throw new ScooterNotFoundException(id);

            if (scooter.IsRented)
                throw new ScooterAlreadyRentedException(id);

            scooter.IsRented = true;
            _rentalStartTimes[id] = _timeProvider.Now;
        }

        public decimal EndRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            if (scooter == null)
                throw new ScooterNotFoundException(id);

            if (!scooter.IsRented)
                throw new ScooterAlreadyRentedException(id);

            scooter.IsRented = false;

            var startTime = _rentalStartTimes[id];
            var duration = _timeProvider.Now - startTime;

            var cost = (decimal)duration.TotalMinutes * scooter.PricePerMinute;
            return cost;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            decimal totalIncome = 0m;

            foreach (var rental in _rentalStartTimes)
            {
                var scooterId = rental.Key;
                var startTime = rental.Value;

                if (year.HasValue && startTime.Year != year.Value)
                    continue;

                var scooter = _scooterService.GetScooterById(scooterId);

                if (scooter.IsRented)
                {
                    if (includeNotCompletedRentals)
                    {
                        var durationTillNow = _timeProvider.Now - startTime;
                        var currentIncome = (decimal)durationTillNow.TotalMinutes * scooter.PricePerMinute;

                        if (currentIncome < 0)
                        {
                            throw new NegativeIncomeException();
                        }

                        totalIncome += currentIncome;
                    }
                    continue;
                }

                var endTime = _timeProvider.Now;
                var duration = endTime - startTime;
                var completedRentalIncome = (decimal)duration.TotalMinutes * scooter.PricePerMinute;

                if (completedRentalIncome < 0)
                {
                    throw new NegativeIncomeException();
                }

                totalIncome += completedRentalIncome;
            }

            if (totalIncome < 0)
            {
                throw new NegativeIncomeException();
            }

            return totalIncome;
        }

    }
}
