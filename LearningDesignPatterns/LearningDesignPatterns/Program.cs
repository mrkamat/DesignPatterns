using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets try strategy pattern");
            StrategyPattern.MallardDuck myMallardDuck = new StrategyPattern.MallardDuck();
            myMallardDuck.display();
            myMallardDuck.performFly();

            StrategyPattern.RubberDuck myRubberDuck = new StrategyPattern.RubberDuck();
            myRubberDuck.display();
            myRubberDuck.performFly();

            Console.ReadLine();
        }
    }
}
