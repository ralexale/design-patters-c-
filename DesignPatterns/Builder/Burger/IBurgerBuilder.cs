using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Builder.Burger
{
    public interface IBurgerBuilder
    {

        void BuildBread(string bread);
        void BuildMeat(string meat);
        void BuildCheese(string cheese);
        void BuildLettuce(string lettuce);
        void BuildTomato(string tomato);
        void BuildDressing(string dressing);
        void BuildPickle(string pickle);
        void BuildBacon(string bacon);
        void Reset();

        string GetBurger();
    }
}
