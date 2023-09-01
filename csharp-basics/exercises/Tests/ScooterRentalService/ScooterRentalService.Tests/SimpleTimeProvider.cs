
namespace ScooterRentalService.Tests
{
    public class SimpleTimeProvider : ITimeProvider
    {
        public DateTime Now => DateTime.Now;
    }
}
