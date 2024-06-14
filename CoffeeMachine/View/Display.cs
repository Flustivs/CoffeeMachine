using CoffeeMachine.Model;
using CoffeeMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.View
{
    internal class Display: IDisplay
    {
        public string SelfMadeCoffee()
        {
            bool h = true;
            while (h)
            {

                Console.WriteLine("If you press 'y' it will make coffee by standards, or 'n' for\n" +
                    "putting an amount of liter Water and grams of Coffee Beans\n" +
                    "ESC for closing");
                Console.WriteLine("y/n");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.Y:
                        h = false;
                        return "y";
                    case ConsoleKey.N:
                        h = false;
                        return "n";
                    case ConsoleKey.Escape:
                        h = false;
                        break;
                    default:
                        h = true;
                        break;
                }
                Console.Clear();
            }
            return null;
        }

        public void SetFilter()
        {
            while (true)
            {
                Console.WriteLine("Press y to add filter");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "Y")
                {
                    break;
                }
                Console.Clear();
            }
        }
        public float GetWater()
        {
            while (true)
            {
                float output = 0;
                Console.WriteLine("How many liters water are you adding?");
                try
                {
                    string answer = Console.ReadLine();
                    if (answer.Contains('.'))
                    {
                        answer = answer.Replace('.', ',');
                    }
                    output = float.Parse(answer);
                }
                catch
                {
                    Console.WriteLine("Not Valid");
                }
                if (output != 0)
                {
                    return output;
                }
            }
        }

        public int GetCoffeeBeans()
        {
            while (true)
            {
                int output = 0;
                Console.WriteLine("How many grams of coffee beans are you adding?");
                try
                {
                    output = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Not Valid");
                }
                if (output != 0)
                {
                    return output;
                }
            }
        }

        public int GetCoffeeBeansperCup()
        {
            while (true)
            {
                int output = 0;
                Console.WriteLine("How many grams of coffee beans per cup do you want?");
                try
                {
                    output = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Not Valid");
                }
                if (output != 0)
                {
                    return output;
                }
            }
        }

        public int GetWaterPerCup()
        {
            while (true)
            {
                int output = 0;
                Console.WriteLine("How many milliliters water per cup do you want?");
                try
                {
                    output = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Not Valid");
                }
                if (output != 0)
                {
                    return output;
                }
            }
        }

        public void CoffeeInfo(Coffee coffee)
        {
            string text = "Grams Coffee Beans: " + coffee.beansAmount + "\n" +
                "Liter Water: " + coffee.literWater + "\n" +
                "Milliliters per cup: " + coffee.mlPerCup + "\n" +
                "Coffee Beans per cup: " + coffee.beansPerCup;
            Console.WriteLine(text);
        }

        public void MakeCoffee(int coffeAmount)
        {
            Console.WriteLine(coffeAmount + " Coffee(s) made");
        }

        public void NotEnough()
        {
            Console.WriteLine("Not enough to make coffee");
        }
    }
}
