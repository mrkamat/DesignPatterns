using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.ObserverPattern
{
    public class WeatherData
    {
        public void TestWeatherData()
        {
            WeatherStation station = new WeatherStation();
            PlasticDisplay plasticDisplay = new PlasticDisplay();
            MetalDisplay metalDisplay = new MetalDisplay();
            GlassDisplay glassDisplay = new GlassDisplay();

            Console.WriteLine("\nAdding plastic display and metal display as observesr");
            station.AddObserver(plasticDisplay);
            station.AddObserver(metalDisplay);
            station.NotifyObservers();

            Console.WriteLine("\nAdding glass display also as observesr");
            station.AddObserver(glassDisplay);
            station.NotifyObservers();

            Console.WriteLine("\nRemoving metal display as observesr");
            station.DeleteObserver(metalDisplay);
            station.NotifyObservers();
        }
    }
}
