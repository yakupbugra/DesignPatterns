using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Subject subject = new Subject();

            Observer1 observer1 = new Observer1();
            subject.RegisterObserver(observer1);

            Observer2 observer2 = new Observer2();
            subject.RegisterObserver(observer2);

            subject.DoSomething();
        }
    }
}