using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger _logger;
        private static readonly object padlock = new object();
        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }
            return _logger;
        }

        // Another way using getter method
        private static Logger _instance;

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
                return _instance;
            }
        }

        public void Log(string content)
        {
            string filePath = @"F:\Logs\TestLog.txt";
            
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(DateTime.Now.ToString()+ "Just created this file");
                sw.WriteLine(DateTime.Now.ToString() + content);
                sw.WriteLine(DateTime.Now.ToString()+"---------End of Log-------");
            }
        }
    }
}


