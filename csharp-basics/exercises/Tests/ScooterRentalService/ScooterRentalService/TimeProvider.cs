namespace ScooterRentalService
{
    public class RealTimeProvider : ITimeProvider
    {
        public DateTime Now => DateTime.Now;
    }

    public class MockTimeProvider : ITimeProvider
    {
        public DateTime Now { get; set; }
    }
}