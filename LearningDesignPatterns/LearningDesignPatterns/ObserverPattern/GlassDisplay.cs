using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.ObserverPattern
{
    class GlassDisplay : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Glass display is updated");
        }
    }
}
