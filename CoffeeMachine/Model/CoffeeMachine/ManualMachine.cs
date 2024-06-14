using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Model.CoffeeMachine
{
    internal class ManualMachine: MainMachine
    {
        public ManualMachine(int _coffeBeans, float _literWaters, int _beansPerCup, int _mlPerCup)
        {
            coffeeBeansAmount = _coffeBeans;
            literWaters = _literWaters;
            beansPerCup = _beansPerCup;
            mlPerCup = _mlPerCup;
        }
        public override Coffee MakeCoffee()
        {
            if (mlPerCup >= 0 && beansPerCup >= 0 && coffeeBeansAmount >= 0 && literWaters >= 0)
            {
                MakeCoffeePerCup();
                return new Coffee(mlPerCup, beansPerCup, coffeeBeansAmount, literWaters);
            }
            return null;
        }
    }
}
