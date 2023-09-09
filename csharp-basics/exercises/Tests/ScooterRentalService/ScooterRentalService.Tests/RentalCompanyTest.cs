using Moq;

namespace ScooterRentalService.Tests
{
    [TestClass]
    public class RentalCompanyTests
    {
        private RentalCompany _rentalCompany;
        private Mock<IScooterService> _mockScooterService;
        private Mock<ITimeProvider> _mockTimeProvider;
        private const string TestScooterId = "testId";

        [TestInitialize]
        public void SetUp()
        {
            _mockScooterService = new Mock<IScooterService>();
            _mockTimeProvider = new Mock<ITimeProvider>();
            _rentalCompany = new RentalCompany("TestCompany", _mockScooterService.Object, _mockTimeProvider.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StartRent_AlreadyRentedScooter_ThrowsException()
        {
            var testScooter = new Scooter(TestScooterId, 1.0m);
            _mockScooterService.Setup(m => m.GetScooterById(TestScooterId)).Returns(testScooter);

            _rentalCompany.StartRent(TestScooterId);
            _rentalCompany.StartRent(TestScooterId);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EndRent_ScooterWasNotRented_ThrowsException()
        {
            _mockScooterService.Setup(m => m.GetScooterById(TestScooterId)).Returns(new Scooter(TestScooterId, 1.0m));

            _rentalCompany.EndRent(TestScooterId);
        }

        [TestMethod]
        public void GivenRentedScooter_WhenCalculatingIncomeAfterReturning_ThenReturnsCorrectIncome()
        {
            _mockTimeProvider = new Mock<ITimeProvider>();
            DateTime currentTime = DateTime.Now;
            _mockTimeProvider.Setup(m => m.Now).Returns(currentTime);

            var scooterService = new Mock<IScooterService>();
            scooterService.Setup(x => x.GetScooterById(TestScooterId)).Returns(new Scooter(TestScooterId, 1.0m));

            _rentalCompany = new RentalCompany("TestCompany", scooterService.Object, _mockTimeProvider.Object);

            _rentalCompany.StartRent(TestScooterId);

            _mockTimeProvider.Setup(m => m.Now).Returns(currentTime.AddMinutes(1));

            _rentalCompany.EndRent(TestScooterId);

            var income = _rentalCompany.CalculateIncome(null, true);
            Assert.AreEqual(1.0m, income);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StartRent_NonExistentScooter_ThrowsException()
        {
            _mockScooterService.Setup(m => m.GetScooterById(TestScooterId)).Returns((Scooter)null);

            _rentalCompany.StartRent(TestScooterId);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EndRent_NonExistentScooter_ThrowsException()
        {
            _mockScooterService.Setup(m => m.GetScooterById(TestScooterId)).Returns((Scooter)null);

            _rentalCompany.EndRent(TestScooterId);
        }

        [TestMethod]
        public void CalculateIncome_MultipleScooters_ReturnsCorrectIncome()
        {
            DateTime currentTime = DateTime.Now;
            _mockTimeProvider.Setup(m => m.Now).Returns(currentTime);

            _mockScooterService.Setup(x => x.GetScooterById("testId1")).Returns(new Scooter("testId1", 1.0m));
            _mockScooterService.Setup(x => x.GetScooterById("testId2")).Returns(new Scooter("testId2", 1.5m));

            _rentalCompany.StartRent("testId1");
            _mockTimeProvider.Setup(m => m.Now).Returns(currentTime.AddMinutes(1));
            _rentalCompany.EndRent("testId1");

            _rentalCompany.StartRent("testId2");
            _mockTimeProvider.Setup(m => m.Now).Returns(currentTime.AddMinutes(2));
            _rentalCompany.EndRent("testId2");

            var income = _rentalCompany.CalculateIncome(null, true);
            Assert.AreEqual(2.5m, income);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RentalCompany_NullScooterService_ThrowsException()
        {
            new RentalCompany("TestCompany", null, _mockTimeProvider.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RentalCompany_NullTimeProvider_ThrowsException()
        {
            new RentalCompany("TestCompany", _mockScooterService.Object, null);
        }
    }
}