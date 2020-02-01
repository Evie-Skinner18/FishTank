using NUnit.Framework;

namespace FishTank.Tests
{
    public class FishTankTests
    {
        private FishTank _fishTank;

        [SetUp]
        public void Setup()
        {
            _fishTank = new FishTank();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}