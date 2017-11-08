using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern
{
    public interface IObservable
    {
        List<IObserver> Observers { get; set; }

        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers();
    }
}