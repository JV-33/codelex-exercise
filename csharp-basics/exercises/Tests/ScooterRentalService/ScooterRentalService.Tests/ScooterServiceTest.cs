namespace ScooterRentalService
{
    [TestClass]
    public class ScooterServiceTests
    {
        private ScooterService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new ScooterService();
        }

        [TestMethod]
        public void GivenValidScooterIdAndPrice_WhenAddScooter_ThenScooterIsAdded()
        {
            var service = new ScooterService();
            string testScooterId = "testId";
            decimal testPricePerMinute = 1.0m;

            service.AddScooter(testScooterId, testPricePerMinute);

            var addedScooter = service.GetScooterById(testScooterId);
            Assert.IsNotNull(addedScooter); 
            Assert.AreEqual(testScooterId, addedScooter.Id); 
            Assert.AreEqual(testPricePerMinute, addedScooter.PricePerMinute); 
        }

         [TestMethod]
        public void GivenValidScooterId_WhenGetScooterById_ThenReturnsCorrectScooter()
        {
            var service = new ScooterService();
            string testScooterId = "testId2";
            decimal testPricePerMinute = 2.0m;
            service.AddScooter(testScooterId, testPricePerMinute);

            var retrievedScooter = service.GetScooterById(testScooterId);

            Assert.IsNotNull(retrievedScooter);
            Assert.AreEqual(testScooterId, retrievedScooter.Id);
            Assert.AreEqual(testPricePerMinute, retrievedScooter.PricePerMinute);
        }

        [TestMethod]
        public void WhenGetScooters_ThenReturnsAllScooters()
        {
            var service = new ScooterService();
            service.AddScooter("testId3", 1.0m);
            service.AddScooter("testId4", 2.0m);

            var scooters = service.GetScooters();

            Assert.AreEqual(2, scooters.Count);
            Assert.IsNotNull(scooters.FirstOrDefault(s => s.Id == "testId3"));
            Assert.IsNotNull(scooters.FirstOrDefault(s => s.Id == "testId4"));
        }

        [TestMethod]
        public void GivenValidScooterId_WhenRemoveScooter_ThenScooterIsRemoved()
        {
            var service = new ScooterService();
            string testScooterId = "testId5";
            service.AddScooter(testScooterId, 1.0m);

            service.RemoveScooter(testScooterId);

            try
            {
                var removedScooter = service.GetScooterById(testScooterId);
                Assert.IsNull(removedScooter); 
            }
            catch (ScooterNotFoundException)
            {
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ScooterNotFoundException))]
        public void GivenNonExistingScooterId_WhenRemoveScooter_ThenThrowsException()
        {
            var service = new ScooterService();
            string testScooterId = "nonexistentId";
            service.RemoveScooter(testScooterId);
        }

        [TestMethod]
        [ExpectedException(typeof(DuplicateScooterException))]
        public void GivenExistingScooterId_WhenAddScooter_ThenThrowsDuplicateScooterException()
        {
            var service = new ScooterService();
            string testScooterId = "testId6";
            decimal testPricePerMinute = 1.0m;

            service.AddScooter(testScooterId, testPricePerMinute);
            service.AddScooter(testScooterId, testPricePerMinute); 
        }

        [TestMethod]
        [ExpectedException(typeof(ScooterNotFoundException))]
        public void GivenNonExistingScooterId_WhenGetScooterById_ThenThrowsScooterNotFoundException()
        {
            var service = new ScooterService();
            string testScooterId = "nonexistentId";

            service.GetScooterById(testScooterId);
        }

        [TestMethod]
        [ExpectedException(typeof(NoScootersAvailableException))]
        public void WhenGetScootersWithNoneAvailable_ThenThrowsNoScootersAvailableException()
        {
            var service = new ScooterService();
            service.GetScooters(); 
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidScooterPriceException))] 
        public void GivenNegativePrice_WhenAddScooter_ThenThrowsInvalidScooterPriceException()
        {
            var service = new ScooterService();
            string testScooterId = "testId7";
            decimal negativeTestPrice = -1.0m;

            service.AddScooter(testScooterId, negativeTestPrice);
        }

        [TestMethod]
        public void WhenAddMultipleScooters_UptoBoundary_ThenAllAddedSuccessfully()
        {
            var service = new ScooterService();
            int maxScooters = 100;

            for (int i = 0; i < maxScooters; i++)
            {
                service.AddScooter($"testId{i}", 1.0m);
            }

            var scooters = service.GetScooters();
            Assert.AreEqual(maxScooters, scooters.Count);
        }

        [TestMethod]
        public void GivenExistingScooterId_WhenAddScooter_ThenNoAdditionalScooterIsAdded()
        {
            var service = new ScooterService();
            string testScooterId = "testId8";
            decimal testPricePerMinute = 1.0m;

            service.AddScooter(testScooterId, testPricePerMinute);
            try
            {
                service.AddScooter(testScooterId, testPricePerMinute);
            }
            catch (DuplicateScooterException)
            {
            }

            var scooters = service.GetScooters();
            Assert.AreEqual(1, scooters.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ScooterNotFoundException))]
        public void GivenValidScooterId_WhenRemoveScooter_ThenThrowsScooterNotFoundException()
        {
            var service = new ScooterService();
            string testScooterId = "testId9";
            service.AddScooter(testScooterId, 1.0m);

            service.RemoveScooter(testScooterId);
            service.GetScooterById(testScooterId); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullOrEmptyScooterId_WhenAddScooter_ThenThrowsArgumentNullException()
        {
            var service = new ScooterService();
            string testScooterId = null; 
            decimal testPricePerMinute = 1.0m;

            service.AddScooter(testScooterId, testPricePerMinute);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullId_WhenAddScooter_ThenThrowsArgumentNullException()
        {
            var service = new ScooterService();
            string testScooterId = null;
            decimal testPricePerMinute = 1.0m;

            service.AddScooter(testScooterId, testPricePerMinute);
        }
    }
}