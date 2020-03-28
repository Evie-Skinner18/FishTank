using System;
using FishTank;
using FishTank.Models;

namespace FishTank.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var angelFish = new AngelFish(0.3f);
            var babelFish = new BabelFish(0.5f);
            var goldFish = new GoldFish(1.0f);

            var eviesFishTank = new FishTank();
            eviesFishTank.AddFish(angelFish);
            eviesFishTank.AddFish(babelFish);
            eviesFishTank.AddFish(goldFish);

            var feedingTimeMessage = eviesFishTank.Feed();

            Console.WriteLine("Hello my sweet fishies!");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(feedingTimeMessage);
        }
    }
}
