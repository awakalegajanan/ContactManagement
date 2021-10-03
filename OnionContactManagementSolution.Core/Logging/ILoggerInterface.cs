using System;
using System.Collections.Generic;
using System.Text;


namespace OnionContactManagementSolution.Core.Logging
{
    public interface ILoggerInterface
    {
        void Info(string message);
        void Debug(string message);
        void Error(Exception exception, string message);
    }
}
