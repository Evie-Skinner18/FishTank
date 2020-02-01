using FishTank.Models.Common;

namespace FishTank.Tests
{
    public class FakeFish : IFish
    {

        private float _foodWeight { get; set; }

        public void SetFoodWeight()
        {
            _foodWeight = 0.5f;
        }

        public float GetFoodWeight()
        {
            return _foodWeight;
        }
    }
}