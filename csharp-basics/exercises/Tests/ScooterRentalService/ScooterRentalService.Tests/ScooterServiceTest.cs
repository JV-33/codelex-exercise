namespace ScooterRentalService
{
    [TestClass]
    public class ScooterServiceTests
    {
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
    }
}
