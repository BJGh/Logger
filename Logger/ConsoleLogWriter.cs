using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class ConsoleLogWriter:ILogWriter
    {
      public virtual void LogInfo(string message)
        {
            string MessageType = "info";
            PrintLog(MessageType,message, ConsoleColor.White);
        }
        public virtual void LogWarning(string message)
        {
            string MessageType = "Warning";
            PrintLog(MessageType, message, ConsoleColor.Yellow);
        }
        public virtual void LogError(string message)
        {
            string MessageType = "Error";
            PrintLog(MessageType, message, ConsoleColor.Red);
        }

        private void PrintLog(string messagetype,string message, ConsoleColor color)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd-hh:mm:ss}\t" + messagetype + "\t" + message);
            Console.ForegroundColor = prevColor;

        }
    }
}
