using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.StrategyPattern
{
    public abstract class Duck
    {

        // This definitely needs to be utilized by every subclass and have it use a different display for each
        public abstract void display();

        // This may be shared with some subclasses but not all will definitely be different
        // public abstract void fly();
        // so here we are now using an Interface instead to define how we will fly.
        public IFlyBehavior flyBehavior;

        public void performFly()
        {
            flyBehavior.fly();
        }
    }
}
