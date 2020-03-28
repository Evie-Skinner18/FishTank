using FishTank.Models.Common;

namespace FishTank.Models
{
    public class AngelFish : IFish
    {
        private float _foodWeight { get; set; }

        public AngelFish(float foodWeight)
        {
            _foodWeight = foodWeight;
        }

        public float GetFoodWeight()
        {
            return _foodWeight;
        }

        public string PrintMessage()
        {
            return $"The angel fish needs g of food";
        }
    }
}
