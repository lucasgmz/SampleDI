using SampleDI.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDI.Domain.Logger.Interface
{
    public interface ILoggerService : IBaseService
    {
        void Log(string message);
    }
}
