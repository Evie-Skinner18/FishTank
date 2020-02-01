using System;
using FishTank.Models.Common;

namespace FishTank.Models
{
    public class GoldFish : IFish
    {
        private float _foodWeight { get; set; }

        // we would have to go inside the Goldsish class to change the food weight so this isn't ideal, but don't want to
        // over complicate things
        public void SetFoodWeight()
        {
            _foodWeight = 0.1f;
        }

        public float GetFoodWeight()
        {
            return _foodWeight;
        }
    }
}
