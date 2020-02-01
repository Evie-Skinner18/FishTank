using FishTank.Models.Common;

namespace FishTank.Models
{
    public class BabelFish : IFish
    {
        private float _foodWeight { get; set; }

        public BabelFish(float foodWeight)
        {
            _foodWeight = foodWeight;
        }

        public float GetFoodWeight()
        {
            return _foodWeight;
        }

        public string PrintMessage()
        {
            return $"The babel fish needs {_foodWeight}g of food";
        }
    }
}
