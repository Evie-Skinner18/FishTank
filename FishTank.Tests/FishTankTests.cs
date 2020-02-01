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
            Assert.That(goldfishFoodWeight.Equals(0.1f));
        }

        [Test]
        public void CanGetAngelFishFoodWeight_ShouldReturnNoughtPointTwo()
        {
            var angelFishFoodWeight = _angelFish.GetFoodWeight();

            Assert.That(_angelFish, Is.Not.Null);
            Assert.That(angelFishFoodWeight, Is.Not.Null);
            Assert.That(angelFishFoodWeight.Equals(0.2f));
        }

        [Test]
        public void CanGetBabelFishFoodWeight_ShouldReturnNoughtPointThree()
        {
            var babelFishFoodWeight = _babelFish.GetFoodWeight();

            Assert.That(_babelFish, Is.Not.Null);
            Assert.That(babelFishFoodWeight, Is.Not.Null);
            Assert.That(babelFishFoodWeight.Equals(0.3f));
        }

        [Test]
        public void CanGetFakeFishFoodWeight_ShouldReturnNoughtPointSeven()
        {
            var fakeFishFoodWeight = _fakeFish.GetFoodWeight();

            Assert.That(_fakeFish, Is.Not.Null);
            Assert.That(fakeFishFoodWeight, Is.Not.Null);
            Assert.That(fakeFishFoodWeight.Equals(0.7f));
        }

        [Test]
        public void CanPrintGoldFishMessage_ShouldReturnTheGoldfishNeedsNoughtPointOneGramsOfFood()
        {
            var goldFishMessage = _goldFish.PrintMessage();
            Assert.That(_goldFish, Is.Not.Null);
            Assert.That(goldFishMessage, Is.Not.Null);
            Assert.That(goldFishMessage.Equals("The goldfish needs 0.1g of food"));
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
            _fishTank.AddFish(_goldFish);
            _fishTank.AddFish(_angelFish);
            _fishTank.AddFish(_babelFish);
            _fishTank.AddFish(_fakeFish);

            var allFishFeedingMessages = _fishTank.Feed();

            Assert.That(_fishTank, Is.Not.Null);            
        }

        

        
    }
}