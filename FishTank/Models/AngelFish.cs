using FishTank.Models.Common;

namespace FishTank.Models
{
    public class AngelFish : IFish
    {
        private float _foodWeight { get; set; }

        public void SetFoodWeight()
        {
            _foodWeight = 0.2f;
        }

        public float GetFoodWeight()
        {
            return _foodWeight;
        }
    }
}
