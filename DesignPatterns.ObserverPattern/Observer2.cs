using System;

namespace DesignPatterns.ObserverPattern
{
    public class Observer2 : IObserver
    {
        public void Action()
        {
            Console.WriteLine("Observer2 notified");
        }
    }
}