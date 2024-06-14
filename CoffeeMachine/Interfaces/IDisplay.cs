using CoffeeMachine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Interfaces
{
    internal interface IDisplay
    {
        string SelfMadeCoffee();
        public void SetFilter();
        public float GetWater();
        int GetCoffeeBeans();
        int GetCoffeeBeansperCup();
        int GetWaterPerCup();
        void CoffeeInfo(Coffee coffee);
        void MakeCoffee(int coffeAmount);
        void NotEnough();
    }
}
