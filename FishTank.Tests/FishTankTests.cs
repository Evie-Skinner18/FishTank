using FishTank.Models;
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
        }

        [Test]
        public void CanAddFishToTheFishTank_ShouldRevealThreeFish()
        {
            // arrange
            _fishTank.AddFish(_goldFish);
            _fishTank.AddFish(_angelFish);


            // act

            // assert
        }
    }
}