using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.ObserverPattern
{
    class PlasticDisplay : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Plastic display is updated");
        }
    }
}
