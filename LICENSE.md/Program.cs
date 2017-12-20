using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                Console.WriteLine(5 / i);
            }
            catch (Exception e)
            {
                SimpleLogger.Instance.Debug(e);
            }
        }
    }
}
