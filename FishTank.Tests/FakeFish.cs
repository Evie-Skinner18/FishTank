using FishTank.Models.Common;

namespace FishTank.Tests
{
    public class FakeFish : IFish
    {

        private float _foodWeight { get; set; }

        public FakeFish(float foodWeight)
        {
            _foodWeight = foodWeight;
        }

        public float GetFoodWeight()
        {
            return _foodWeight;
        }

        public string PrintMessage()
        {
            return $"Please feed the fake fish {_foodWeight}g of food.";
        }
    }
}