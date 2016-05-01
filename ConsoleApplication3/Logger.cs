using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulator
{
    class Logger
    {
        public Logger(string name)
        {
            loggerName = name;
        }

        public void Error(string message)
        {
            Console.WriteLine("{0}/Error: {1}", loggerName, message);
        }

        public void Error(string message, string data)
        {
            string err_message = String.Format("{0}/Error: {1}", loggerName, message);
            Console.WriteLine(err_message, data);
        }

        public void Warning(string message)
        {
            Console.WriteLine("{0}/Warning: {1}", loggerName, message);
        }

        public void Warning(string message, string data)
        {
            string err_message = String.Format("{0}/Warning: {1}", loggerName, message);
            Console.WriteLine(err_message, data);
        }

        public void Info(string message)
        {
            Console.WriteLine("{0}/Info: {1}", loggerName, message);
        }

        public void Info(string message, string data)
        {
            string err_message = String.Format("{0}/Info: {1}", loggerName, message);
            Console.WriteLine(err_message, data);
        }

        private string loggerName;
    }
}
