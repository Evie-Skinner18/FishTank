using System;
namespace FishTank.Models.Common
{
    public interface IFish
    {
        float GetFoodWeight();

        string PrintMessage();
    }
}
