using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.StrategyPattern
{
    public class SimpleFlyBehavior : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I have a plain and simple fly");
        }
    }
}
