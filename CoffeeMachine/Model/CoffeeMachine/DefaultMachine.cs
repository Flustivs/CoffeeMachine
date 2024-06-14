using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Model.CoffeeMachine
{
    internal class DefaultMachine: MainMachine
    {
        public DefaultMachine(float waterAmount, int coffeeBeans)
        {
            literWaters = waterAmount;
            coffeeBeansAmount = coffeeBeans;
            beansPerCup = 15;
            mlPerCup = 150;
        }
        public override Coffee MakeCoffee()
        {
            MakeCoffeePerCup();
            return new Coffee(mlPerCup, beansPerCup, coffeeBeansAmount, literWaters);
        }
    }
}
