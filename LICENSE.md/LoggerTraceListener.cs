using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class LoggerTraceListener : TraceListener
    {
        private string fileName;
        public LoggerTraceListener()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\";
            //string basePath = "D:\\Logs\\";
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
            fileName = basePath + string.Format("Log-{0}.txt", DateTime.Now.ToString("yyyyMMdd"));
        }
        public override void Write(string message)
        {
            string mes = Format(message, "");
            File.AppendAllText(fileName, mes);
        }

        public override void WriteLine(string message)
        {
            string mes = Format(message, "");
            File.AppendAllText(fileName, mes);
        }

        public override void Write(Object message, string category)
        {
            string mes = Format(message, category);
            File.AppendAllText(fileName, mes);
        }

        public override void WriteLine(Object message, string category)
        {
            string mes = Format(message, category);
            File.AppendAllText(fileName, mes);
        }
        public string Format(object obj, string category)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("[{0}]", DateTime.Now.ToString("yyyyMMdd"));
            if (!string.IsNullOrEmpty(category))
            {
                strBuilder.AppendFormat("[{0}]", category);
            }

            if (obj is Exception)
            {
                var excp = (Exception)obj;
                strBuilder.Append(excp.Message + "\r\n");
                strBuilder.Append(excp.StackTrace + "\r\n");
            }
            else
            {
                strBuilder.Append(obj.ToString() + "\r\n");
            }
            return strBuilder.ToString();
        }
    }
}
