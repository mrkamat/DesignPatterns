using LearningDesignPatterns.DecoratorPattern.CoffeeExample;
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
            int i = 0;
            do
            {
                Console.WriteLine("Please choose the pattern you want to run.");
                Console.WriteLine("1. Strategy Pattern \n2. Observer Pattern");
                Console.WriteLine("3. Decorator Pattern\n-1. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case -1:
                        return;
                    case 1:
                        TestStrategyPattern();
                        break;
                    case 2:
                        TestObserverPattern();
                        break;
                    case 3:
                        TestDecoratorPattern();
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        private static void TestDecoratorPattern()
        {
            Beverage coffee = new Coffee();
            Console.WriteLine("{0}....{1}", coffee.getDescription(), coffee.getCost());

            Beverage vanillaCoffee = new Vanilla(new Coffee());
            Console.WriteLine("{0}....{1}", vanillaCoffee.getDescription(), vanillaCoffee.getCost());

            Beverage CaramelVanillaCoffee = new Caramel(new Vanilla(new Coffee()));
            Console.WriteLine("{0}....{1}", CaramelVanillaCoffee.getDescription(), CaramelVanillaCoffee.getCost());
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
