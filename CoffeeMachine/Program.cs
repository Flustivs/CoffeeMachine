using CoffeeMachine.Controller;
using CoffeeMachine.Interfaces;
using CoffeeMachine.View;

namespace CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDisplay display = new Display();
            Start s = new Start(display);
            s.StartMachine();
        }
    }
}
