using SampleDI.Domain;
using SampleDI.Domain.Logger.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDI.Services.Logger
{
    public class LoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine(string.Format("[LOG]: {0}", message));
        }
    }
}
