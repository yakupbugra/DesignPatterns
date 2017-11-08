using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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