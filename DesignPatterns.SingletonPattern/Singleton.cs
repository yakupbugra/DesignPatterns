using System;

namespace DesignPatterns.SingletonPattern
{
    public class Singleton
    {
        private static volatile Singleton single;
        private static Object lock_obj = new object();
        public string MyProperty { get; set; }

        protected Singleton()
        {
        }

        public static Singleton CreateSingletonObject()
        {
            lock (lock_obj)
            {
                if (single == null)
                {
                    single = new Singleton();
                }
                return single;
            }
        }
    }
}