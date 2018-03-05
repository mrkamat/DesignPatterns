using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.ObserverPattern
{
    class MetalDisplay : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Metal display is updated");
        }
    }
}
