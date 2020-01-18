using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();
            Console.WriteLine(logger.GetHashCode());
            logger.Log("---------Start of Log-------");
            TestLogger.TestingLogging();

        }
    }
}
