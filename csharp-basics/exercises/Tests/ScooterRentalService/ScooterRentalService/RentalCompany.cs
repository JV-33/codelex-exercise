namespace ScooterRentalService
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        private readonly Dictionary<string, DateTime> _rentalStartTime = new Dictionary<string, DateTime>();
        private readonly Dictionary<int, decimal> _yearlyIncome = new Dictionary<int, decimal>();
        private readonly ITimeProvider _timeProvider;
        private const int SomeMinimumYear = 2023;
        private const decimal MAX_DAILY_CHARGE = 20M;
        private const int MINUTES_IN_DAY = 1440;

        public string Name { get; private set; }

        public RentalCompany(string companyName, IScooterService scooterService, ITimeProvider timeProvider)
        {
            _scooterService = scooterService ?? throw new ArgumentNullException(nameof(scooterService));
            _timeProvider = timeProvider ?? throw new ArgumentNullException(nameof(timeProvider));
            Name = companyName ?? throw new ArgumentNullException(nameof(companyName));
        }

        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            if (scooter == null)
            {
                throw new InvalidOperationException($"Scooter with ID: {id} does not exist.");
            }
            if (_rentalStartTime.ContainsKey(id))
            {
                throw new InvalidOperationException($"Scooter with ID: {id} is already being rented.");
            }
            _rentalStartTime[id] = _timeProvider.Now;
        }

        public decimal EndRent(string id)
        {
            ValidateRent(id);
            var scooter = GetScooterById(id);
            ValidateScooterPricing(scooter);
            decimal totalCharge = CalculateTotalCharge(scooter, id);
            UpdateYearlyIncome(totalCharge);
            _rentalStartTime.Remove(id);
            return totalCharge;
        }

        private void ValidateRent(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException(nameof(id), "ID cannot be null or empty.");
            }

            if (!_rentalStartTime.ContainsKey(id))
            {
                throw new InvalidOperationException($"Scooter with ID: {id} is not being rented.");
            }
        }

        private Scooter GetScooterById(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            if (scooter == null)
            {
                throw new InvalidOperationException($"No scooter found with ID: {id}.");
            }
            return scooter;
        }

        private void ValidateScooterPricing(Scooter scooter)
        {
            if (scooter.PricePerMinute <= 0)
            {
                throw new InvalidOperationException($"Invalid price per minute for scooter with ID: {scooter.Id}.");
            }
        }

        private decimal CalculateTotalCharge(Scooter scooter, string id)
        {
            var startDateTime = _rentalStartTime[id];
            var endDateTime = _timeProvider.Now;

            if (endDateTime < startDateTime)
            {
                throw new InvalidOperationException("End time cannot be before start time.");
            }

            var totalMinutes = (decimal)(_timeProvider.Now - startDateTime).TotalMinutes;
            var dayCount = (int)(totalMinutes / MINUTES_IN_DAY);

            var dailyCharge = scooter.PricePerMinute * MINUTES_IN_DAY;
            if (dailyCharge > MAX_DAILY_CHARGE) dailyCharge = MAX_DAILY_CHARGE;

            var lastDayMinutes = totalMinutes % MINUTES_IN_DAY;
            var lastDayCharge = lastDayMinutes * scooter.PricePerMinute;
            if (lastDayCharge > MAX_DAILY_CHARGE) lastDayCharge = MAX_DAILY_CHARGE;

            var totalCharge = (dailyCharge * dayCount) + lastDayCharge;

            Console.WriteLine($"Ending rent for {id}. Total minutes: {totalMinutes}. Total charge: {totalCharge}.");
            return totalCharge;
        }

        private void UpdateYearlyIncome(decimal totalCharge)
        {
            int currentYear = DateTime.Now.Year;
            if (_yearlyIncome.ContainsKey(currentYear))
            {
                _yearlyIncome[currentYear] += totalCharge;
            }
            else
            {
                _yearlyIncome[currentYear] = totalCharge;
            }
        }


        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            ValidateYear(year);

            decimal totalIncome = GetIncomeForYear(year);

            Console.WriteLine($"Initial total income: {totalIncome}.");

            if (includeNotCompletedRentals)
            {
                totalIncome += CalculateIncomeFromNotCompletedRentals();
            }

            Console.WriteLine($"Final total income: {totalIncome}.");

            return totalIncome;
        }

        private void ValidateYear(int? year)
        {
            if (year.HasValue && (year < SomeMinimumYear || year > DateTime.Now.Year))
            {
                throw new ArgumentOutOfRangeException(nameof(year), "Specified year is out of valid range.");
            }
        }

        private decimal GetIncomeForYear(int? year)
        {
            if (year.HasValue)
            {
                _yearlyIncome.TryGetValue(year.Value, out var incomeForYear);
                return incomeForYear;
            }
            else
            {
                return _yearlyIncome.Values.Sum();
            }
        }

        private decimal CalculateIncomeFromNotCompletedRentals()
        {
            decimal incomeFromNotCompletedRentals = 0;

            foreach (var id in _rentalStartTime.Keys)
            {
                var scooter = _scooterService.GetScooterById(id);

                if (scooter == null)
                {
                    throw new InvalidOperationException($"No scooter found with ID: {id}.");
                }

                ValidateScooterPricing(scooter);

                var chargeForScooter = CalculateChargeForScooter(scooter, id);

                incomeFromNotCompletedRentals += chargeForScooter;

                Console.WriteLine($"Income from not completed rental for {id}. Total charge: {chargeForScooter}. Updated total income: {incomeFromNotCompletedRentals}.");
            }

            return incomeFromNotCompletedRentals;
        }

        private decimal CalculateChargeForScooter(Scooter scooter, string id)
        {
            var startDateTime = _rentalStartTime[id];
            var currentDateTime = DateTime.Now;

            if (currentDateTime < startDateTime)
            {
                throw new InvalidOperationException("Current time cannot be before start time.");
            }

            var totalMinutes = (decimal)(_timeProvider.Now - startDateTime).TotalMinutes;
            var dayCount = (int)(totalMinutes / MINUTES_IN_DAY);

            var dailyCharge = scooter.PricePerMinute * MINUTES_IN_DAY;
            if (dailyCharge > MAX_DAILY_CHARGE) dailyCharge = MAX_DAILY_CHARGE;

            var lastDayMinutes = totalMinutes % MINUTES_IN_DAY;
            var charge = (dailyCharge * dayCount) + (lastDayMinutes * scooter.PricePerMinute);

            return charge;
        }

    }
}