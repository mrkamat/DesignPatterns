using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new SimpleFlyBehavior();
        }

        public override void display()
        {
            Console.WriteLine("I am a mallardDuck");
        }
    }
}
