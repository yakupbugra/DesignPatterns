using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class Subject : IObservable
    {
        public List<IObserver> Observers { get; set; }

        public Subject()
        {
            Observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Action();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void DoSomething()
        {
            Console.WriteLine("Subject did something");
            NotifyObservers();
        }
    }
}