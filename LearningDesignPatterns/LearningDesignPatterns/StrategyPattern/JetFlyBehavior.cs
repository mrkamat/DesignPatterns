using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.StrategyPattern
{
    public class JetFlyBehavior : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I fly like a jet");
        }
    }
}
