using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingletonPattern
{
    public sealed class Logger : ILogger
    {
        private Logger()
        {
        }

        //private static readonly Lazy<Logger> _logger = new Lazy<Logger>(() => new Logger());

        //public static Logger GetLogger
        //{
        //    get
        //    {
        //        return _logger.Value;
        //    }
        //}

        private static Logger _logger;
        private static readonly object obj = new object();

        public static Logger GetLogger
        {
            get
            {
                if (_logger == null)
                {
                    lock (obj)
                    {
                        if (_logger == null)
                        {
                            _logger = new Logger();
                        }
                    }
                }
                return _logger;
            }
        }

        public void Log(string message)
        {
            lock (obj)
            {
                string filename = string.Format("{0}_2.log", "Exception");
                string filepath = string.Format(@"{0}\{1}", "C:\\Logs", filename);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("------------------------------------------------------------------------------------------------------------------------");
                sb.AppendLine(DateTime.Now.ToString());
                sb.AppendLine(message);
                using (StreamWriter sw = new StreamWriter(filepath, true))
                {
                    sw.Write(sb.ToString());
                    sw.Flush();
                }
            }
        }
    }
}


