using System;
using System.Collections.Generic;
using System.Text;

namespace SampleIOC.Domain.Logger.Interface
{
    public interface ILoggerService
    {
        void Log(string message);
    }
}
