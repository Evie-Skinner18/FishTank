using System.Linq;
using FishTank.Models;
using FishTank.Models.Common;
using NUnit.Framework;

namespace FishTank.Tests
{
    public class FishTankTests
    {
        private GoldFish _goldFish;
        private AngelFish _angelFish;
        private BabelFish _babelFish;
        private FakeFish _fakeFish;

        private FishTank _fishTank;

        [SetUp]
        public void Setup()
        {
            _fishTank = new FishTank();

            _goldFish = new GoldFish(0.1f);
            _angelFish = new AngelFish(0.2f);
            _babelFish = new BabelFish(0.3f);
            _fakeFish = new FakeFish(0.7f);
        }


        [Test]
        public void CanGetGoldFishFoodWeight_ShouldReturnNoughtPointOne()
        {
            var goldfishFoodWeight = _goldFish.GetFoodWeight();

            Assert.That(_goldFish, Is.Not.Null);
            Assert.That(goldfishFoodWeight, Is.Not.Null);
            Assert.That(goldfishFoodWeight.Equals(0.2f));
        }

        [Test]
        public void CanGetAllFishInTheFishTank_ShouldReturnFourFish()
        {
            // arrange   // act
            _fishTank.AddFish(_goldFish);
            _fishTank.AddFish(_angelFish);
            _fishTank.AddFish(_babelFish);
            _fishTank.AddFish(_fakeFish);

            var allFishInTheTank = _fishTank.GetFish();

            // assert
            Assert.That(_fishTank, Is.Not.Null);
            Assert.That(allFishInTheTank, Is.Not.Null);
            Assert.That(allFishInTheTank.Count().Equals(4));
        }

        [Test]
        public void CanFeedAllFishInTheTank_ShouldReturnOneMessagePerFish()
        {

        }

        

        
    }
}