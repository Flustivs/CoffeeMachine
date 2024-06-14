using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMachine.Interfaces;

namespace CoffeeMachine.Model
{
    internal abstract class MainMachine: IMachine
    {
        internal protected int coffeeBeansAmount;
        internal protected float literWaters;
        internal protected int beansPerCup;
        internal protected int mlPerCup;
        internal protected int cupCoffee;

        public MainMachine()
        {

        }
        public abstract Coffee MakeCoffee();
        public void MakeCoffeePerCup()
        {
            float water = literWaters * 1000;
            int beansForCup = (int)coffeeBeansAmount / beansPerCup;
            int waterCup = (int)water / mlPerCup;


            if (waterCup > beansForCup)
            {
                cupCoffee = beansForCup;
            }
            else
            {
                cupCoffee = waterCup;
            }
        }
    }
}
