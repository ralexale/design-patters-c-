using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Builder.Burger
{
    public class BurgerDirector
    {
        private readonly IBurgerBuilder _burgerBuilder;

        public BurgerDirector(IBurgerBuilder burgerBuilder)
        {
            _burgerBuilder = burgerBuilder;
        }

        public void MakeCheseeBurger()
        {
            _burgerBuilder.BuildBread("White");
            _burgerBuilder.BuildMeat("Beef");
            _burgerBuilder.BuildCheese("Cheddar - Mozarella");
            _burgerBuilder.BuildLettuce("Iceberg");
            _burgerBuilder.BuildTomato("Roma");
            _burgerBuilder.BuildDressing("Mayo");
        }

        public void MakeBaconBurger()
        {
            _burgerBuilder.BuildBread("Black");
            _burgerBuilder.BuildMeat("Beef");
            _burgerBuilder.BuildLettuce("Iceberg");
            _burgerBuilder.BuildTomato("Roma");
            _burgerBuilder.BuildDressing("BBQ");
            _burgerBuilder.BuildBacon("Pancetta");
        }
    }
}
