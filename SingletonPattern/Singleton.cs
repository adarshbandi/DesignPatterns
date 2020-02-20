using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    // Sealed restricts inheriting within the class or nested classes
    public sealed class Singleton
    {
        private static Singleton _reference;
        private static int counter = 0;
        private static readonly object obj = new object();

        public static Singleton GetInstance
        {
            get
            {
                // this null check of reference variable ensures locking to occur only when locking is required.. Double-checked-locking
                if (_reference == null)
                {
                    // lock ensures only a single thread to create instance in a multithread scenario
                    lock (obj)
                    {
                        if (_reference == null)
                        {
                            _reference = new Singleton();
                        }
                    }
                }
                return _reference;
            }
        }

        // Private constructor ensures that object is not instantiated outside the class
        private Singleton()
        {
            Console.WriteLine("Conter value is: " + ++counter);
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
