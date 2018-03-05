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
            Console.WriteLine("Please choose the pattern you want to run.");
            Console.WriteLine("1. StrategyPattern \n2. Observer Pattern");
            int choice = Console.Read() - 48;
            switch (choice)
            {
                case 1:
                    TestStrategyPattern();
                    break;
                case 2:
                    TestObserverPattern();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        private static void TestObserverPattern()
        {
            Console.WriteLine("\n\nLets try observer pattern");
            ObserverPattern.WeatherData wd = new ObserverPattern.WeatherData();
            wd.TestWeatherData();
        }

        static void TestStrategyPattern()
        {
            Console.WriteLine("\n\nLets try strategy pattern");
            StrategyPattern.MallardDuck myMallardDuck = new StrategyPattern.MallardDuck();
            myMallardDuck.display();
            myMallardDuck.performFly();

            StrategyPattern.RubberDuck myRubberDuck = new StrategyPattern.RubberDuck();
            myRubberDuck.display();
            myRubberDuck.performFly();
        }
    }
}
