using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.DecoratorPattern.CoffeeExample
{
    public class Vanilla : AddOnDecorator
    {
        Beverage beverage;

        public Vanilla(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override int getCost()
        {
            return this.beverage.getCost() + 1;
        }

        public override string getDescription()
        {
            return this.beverage.getDescription() + " Vanilla";
        }
    }
}
