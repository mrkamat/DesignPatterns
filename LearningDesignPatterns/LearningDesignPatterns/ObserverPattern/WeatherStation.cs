using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private List<IObserver> observers;

        public WeatherStation()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
