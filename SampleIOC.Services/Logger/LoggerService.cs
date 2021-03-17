using SampleIOC.Domain.Logger.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleIOC.Services.Logger
{
    public class LoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine(string.Format("[LOG]: {0}", message));
        }
    }
}
