using CoffeeMachine.Model;
using CoffeeMachine.Model.CoffeeMachine;
using CoffeeMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Controller
{
    internal class Start
    {
        private readonly IDisplay _display;
        public Start(IDisplay display)
        {
            _display = display;
        }
        public void StartMachine()
        {
            string answer = _display.SelfMadeCoffee();
            if (answer != null)
            {
                if (answer == "y" || answer == "Y")
                {
                    DefaultMachine machine = new DefaultMachine(_display.GetWater(), _display.GetCoffeeBeans());
                    _display.SetFilter();
                    Coffee coffee = machine.MakeCoffee();
                    _display.CoffeeInfo(coffee);
                    _display.MakeCoffee(machine.cupCoffee);
                }
                if (answer == "n" || answer == "N")
                {
                    int coffeeBeans = _display.GetCoffeeBeans();
                    float waterAmount = _display.GetWater();
                    int coffeeBeansPerCup = _display.GetCoffeeBeansperCup();
                    int waterPerCup = _display.GetWaterPerCup();
                    _display.SetFilter();
                    ManualMachine machine = new ManualMachine(coffeeBeans, waterAmount, coffeeBeansPerCup, waterPerCup);
                    Coffee coffee = machine.MakeCoffee();
                    _display.CoffeeInfo(coffee);
                    if (machine.cupCoffee > 0)
                    {
                        _display.MakeCoffee(machine.cupCoffee);
                    }
                    else
                    {
                        _display.NotEnough();
                    }
                }
            }

        }
    }
}
