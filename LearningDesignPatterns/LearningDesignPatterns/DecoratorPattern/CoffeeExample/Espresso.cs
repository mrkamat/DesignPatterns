using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.DecoratorPattern.CoffeeExample
{
    public class Espresso : Beverage
    {
        public override int getCost()
        {
            return 2;
        }

        public override string getDescription()
        {
            return "Espresso";
        }
    }
}
