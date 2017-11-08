using System;

namespace DesignPatterns.ObserverPattern
{
    public class Observer1 : IObserver
    {
        public void Action()
        {
            Console.WriteLine("Observer1 notified");
        }
    }
}