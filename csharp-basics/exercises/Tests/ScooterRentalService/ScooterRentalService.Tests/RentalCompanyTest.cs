namespace ScooterRentalService
{
    [TestClass]
    public class RentalCompanyTests
    {
        private const string TestScooterId = "testId";

        [TestMethod]
        public void StartRent_ChangesScooterStatusToRented()
        {
            var scooterService = new ScooterService();
            var rentalCompany = new RentalCompany(scooterService, "TestCompany");
            scooterService.AddScooter(TestScooterId, 1.0m);

            rentalCompany.StartRent(TestScooterId);

            var scooter = scooterService.GetScooterById(TestScooterId);
            Assert.IsTrue(scooter.IsRented);
        }

        [TestMethod]
        public void EndRent_ReturnsCorrectAmount()
        {
            var scooterService = new ScooterService();
            var rentalCompany = new RentalCompany(scooterService, "TestCompany");
            scooterService.AddScooter(TestScooterId, 1.0m);
            rentalCompany.StartRent(TestScooterId);

            Thread.Sleep(TimeSpan.FromMinutes(10));

            decimal amount = rentalCompany.EndRent(TestScooterId);

            Assert.AreEqual(10.0m, amount);
        }

        [TestMethod]
        public void CalculateIncome_ReturnsCorrectAmount()
        {
            var scooterService = new ScooterService();
            var rentalCompany = new RentalCompany(scooterService, "TestCompany");

            scooterService.AddScooter("scooter1", 1.0m);
            rentalCompany.StartRent("scooter1");
            Thread.Sleep(TimeSpan.FromMinutes(10));
            rentalCompany.EndRent("scooter1");

            scooterService.AddScooter("scooter2", 0.5m);
            rentalCompany.StartRent("scooter2");
            Thread.Sleep(TimeSpan.FromMinutes(20));
            rentalCompany.EndRent("scooter2");

            decimal totalIncome = rentalCompany.CalculateIncome(null, true);

            Assert.AreEqual(20.0m, totalIncome);
        }
    }
}