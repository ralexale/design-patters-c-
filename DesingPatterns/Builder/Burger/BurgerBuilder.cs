using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesingPatterns.Builder.Burger
{
    internal class BurgerBuilder : IBurgerBuilder
    {

        private Burger _burger;

        public BurgerBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _burger = new Burger();
        }

        public void BuildBread(string bread)
        {
            _burger.bread = bread;
        }

        public void BuildMeat(string meat)
        {
            _burger.meat = meat;
        }

        public void BuildCheese(string cheese)
        {
            _burger.cheese = cheese;
        }

        public void BuildLettuce(string lettuce)
        {
            _burger.lettuce = lettuce;
        }

        public void BuildTomato(string tomato)
        {
            _burger.tomato = tomato;
        }

        public void BuildDressing(string dressing)
        {
            _burger.dressing = dressing;
        }

        public void BuildPickle(string pickle)
        {
            _burger.pickle = pickle;
        }
        public void BuildBacon(string bacon)
        {
            _burger.bacon = bacon;
        }

        public string GetBurger()
        {
            return JsonSerializer.Serialize(_burger);
        }
    }
}
