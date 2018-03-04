using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new NoFlyBehavior();
        }

        public override void display()
        {
            Console.WriteLine("I am a rubber duck");
        }
    }
}
