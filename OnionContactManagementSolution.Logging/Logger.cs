using OnionContactManagementSolution.Core.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionContactManagementSolution.Logging
{
    public class Logger : ILoggerInterface
    {
        public void Debug(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(Exception exception, string message)
        {
            Console.WriteLine($"Exception details are: {message} and stack trace : {exception.StackTrace}");
        }

        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
