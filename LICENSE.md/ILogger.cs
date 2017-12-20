using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    interface ILogger
    {
        void Warn(Object msg);
        void Info(Object msg);
        void Debug(Object msg);
        void Error(Object msg);

    }
}
