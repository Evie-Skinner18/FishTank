using System;
using System.Collections.Generic;
using FishTank.Models.Common;

namespace FishTank
{
    public class FishTank
    {
        private List<IFish> _allfishToFeed { get; set; }
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
            string currentFishMessage;

            foreach (var fish in _allfishToFeed)
            {
                currentFishMessage = fish.PrintMessage();
                _message += $"\n{currentFishMessage}";
            }

            return _message;
        }

    }
}
