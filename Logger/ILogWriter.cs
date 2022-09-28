using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    interface ILogWriter
    {
        void LogInfo(String message);
        void LogWarning(String message);
        void LogError(String message);
    }
}
