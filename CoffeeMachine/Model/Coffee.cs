using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Model
{
    internal class Coffee
    {
        public int mlPerCup {  get; set; }
        public int beansPerCup { get; set; }
        public int beansAmount { get; set; }
        public float literWater { get; set; }
        public Coffee(int _mlPerCup, int _beansPerCup, int _beansAmount, float _literWater)
        {
            mlPerCup = _mlPerCup;
            beansPerCup = _beansPerCup;
            beansAmount = _beansAmount;
            literWater = _literWater;
        }
    }
}
