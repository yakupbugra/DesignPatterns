using System;

namespace DesignPatterns.SingletonPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var singleton1 = Singleton.CreateSingletonObject();
            var singleton2 = Singleton.CreateSingletonObject();
            var singleton3 = Singleton.CreateSingletonObject();

            singleton1.MyProperty = "Hello World!";

            Console.WriteLine(singleton1.MyProperty);
            Console.WriteLine(singleton2.MyProperty);
            Console.WriteLine(singleton3.MyProperty);
            Console.ReadLine();
        }
    }
}