using CoffeeMachine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Interfaces
{
    internal interface IMachine
    {
        Coffee MakeCoffee();
        void MakeCoffeePerCup();
    }
}
