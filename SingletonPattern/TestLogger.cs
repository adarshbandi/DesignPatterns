using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public static class TestLogger
    {
        public static void TestingLogging()
        {
            Logger logger = Logger.Instance;
            Console.WriteLine(logger.GetHashCode());
            logger.Log("Calling from test logger class");            
        }
    }
}
