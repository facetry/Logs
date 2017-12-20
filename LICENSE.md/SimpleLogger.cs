using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SimpleLogger : ILogger
    {
        private static SimpleLogger instance;
        private SimpleLogger()
        {
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new LoggerTraceListener());
        }
        public static SimpleLogger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SimpleLogger();
                }
                return instance;
            }
        }
        public void Debug(object msg)
        {
            Trace.WriteLine(msg, "Debug");
        }

        public void Error(object msg)
        {
            Trace.WriteLine(msg, "Error");
        }

        public void Info(object msg)
        {
            Trace.WriteLine(msg, "Info");
        }

        public void Warn(object msg)
        {
            Trace.WriteLine(msg, "Warn");
        }
    }
}
