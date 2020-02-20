using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class TestLogger
    {
        private ILogger _logger;
        public TestLogger()
        {
            _logger = Logger.GetLogger;
        }
        public void TestingLogging()
        {
            try
            {
                int a = 0;
                var c = 2 / a;
            }
            catch (DivideByZeroException ex)
            {
                _logger.Log(ex.Message);
            }
        }

        public void LogInfo(string message)
        {
            _logger.Log(message);
        }
    }
}
