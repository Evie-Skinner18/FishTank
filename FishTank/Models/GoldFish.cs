using System;
using FishTank.Models.Common;

namespace FishTank.Models
{
    public class GoldFish : IFish
    {
        private float _foodWeight { get; set; }

        private string _name = "goldfish";

        public GoldFish(float foodWeight)
        {
            _foodWeight = foodWeight;
        }

        public float GetFoodWeight()
        {
            return _foodWeight;
        }

        public string PrintMessage()
        {
            return $"The {_name} needs {_foodWeight}g of food";
        }
    }
}
