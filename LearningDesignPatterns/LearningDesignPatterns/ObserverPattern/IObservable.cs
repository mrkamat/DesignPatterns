﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.ObserverPattern
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void DeleteObserver(IObserver observer);
        void NotifyObservers();
    }
}
