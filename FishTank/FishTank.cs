using System;
using System.Collections.Generic;
using FishTank.Models.Common;

namespace FishTank
{
    public class FishTank
    {
        private List<IFish> _allfishToFeed { get; set; }
        private float _currentFishesFoodWeight { get; set; }
        private string _message { get; set; }

        public FishTank()
        {
            _allfishToFeed = new List<IFish>();
        }

        public void AddFish(IFish fish)
        {
            _allfishToFeed.Add(fish);
        }

        public string Feed()
        {

            foreach (var fish in _allfishToFeed)
            {
                _currentFishesFoodWeight = fish.GetFoodWeight();
            }
            return $"This fish needs {currentFishesFoodWeight}g of food.";
        }

    }
}
