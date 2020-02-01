using System;
using FishTank.Models.Common;

namespace FishTank
{
    public class FishTank
    {
        private IFish _fishToFeed { get; set; }

        public FishTank(IFish fish)
        {
            _fishToFeed = fish;
        }

        public string Feed()
        {
            var currentFishesFoodWeight = _fishToFeed.GetFoodWeight();
            return $"This fish needs {currentFishesFoodWeight}g of food.";
        }

    }
}
