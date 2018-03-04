using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.StrategyPattern
{
    /// <summary>
    /// We are using a behavior as strategy pattern. This will be implemented by various classes
    /// and each defines a fly method. So this behavior can be used as needed in the classes that 
    /// inherit from Duck class.
    /// </summary>
    public interface IFlyBehavior
    {
        void fly();
    }
}
