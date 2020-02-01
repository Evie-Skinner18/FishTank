using FishTank.Models;
using NUnit.Framework;

namespace FishTank.Tests
{
    public class FishTankTests
    {
        private GoldFish _goldFish;


        private FishTank _fishTank;

        [SetUp]
        public void Setup()
        {
            // as long as we give FishTank an IFish, it doesn't care!
            _fishTank = new FishTank(_goldFish);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}