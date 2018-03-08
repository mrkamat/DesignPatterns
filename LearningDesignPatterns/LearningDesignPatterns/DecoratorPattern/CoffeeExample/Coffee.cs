using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.DecoratorPattern.CoffeeExample
{
    public class Coffee : Beverage
    {
        public override int getCost()
        {
            return 1;
        }

        public override string getDescription()
        {
            return "Coffee";
        }
    }
}
