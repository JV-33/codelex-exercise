using ScooterRentalService.Tests;

namespace ScooterRentalService
{
    [TestClass]
    public class RentalCompanyTests
    {
        private const string TestScooterId = "testId";

        [TestMethod]
        public void GivenScooter_WhenStartRent_ThenScooterStatusIsRented()
        {
            var scooterService = new ScooterService();
            var timeProvider = new SimpleTimeProvider();
            var rentalCompany = new RentalCompany(scooterService, timeProvider, "TestCompany");
            scooterService.AddScooter(TestScooterId, 1.0m);

            rentalCompany.StartRent(TestScooterId);

            var scooter = scooterService.GetScooterById(TestScooterId);
            Assert.IsTrue(scooter.IsRented);
        }

        [TestMethod]
        public void GivenRentedScooter_WhenEndRent_ThenScooterStatusIsNotRented()
        {
            var scooterService = new ScooterService();
            var timeProvider = new SimpleTimeProvider();
            var rentalCompany = new RentalCompany(scooterService, timeProvider, "TestCompany");
            scooterService.AddScooter(TestScooterId, 1.0m);

            rentalCompany.StartRent(TestScooterId);
            rentalCompany.EndRent(TestScooterId);

            var scooter = scooterService.GetScooterById(TestScooterId);
            Assert.IsFalse(scooter.IsRented);
        }

        [TestMethod]
        public void GivenRentedAndReturnedScooter_WhenCalculateIncome_ThenReturnsCorrectIncome()
        {
            var scooterService = new ScooterService();
            var mockTimeProvider = new MockTimeProvider { Now = DateTime.Now };
            var rentalCompany = new RentalCompany(scooterService, mockTimeProvider, "TestCompany");
            scooterService.AddScooter(TestScooterId, 1.0m);

            rentalCompany.StartRent(TestScooterId);

            mockTimeProvider.Now = mockTimeProvider.Now.AddMinutes(1);

            rentalCompany.EndRent(TestScooterId);

            var income = rentalCompany.CalculateIncome(null, true);
            Assert.AreEqual(1.0m, income);
        }
    }
}
