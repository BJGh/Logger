using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class FileLogWriter:ILogWriter
    {
        public virtual void LogInfo(string message)
        {
            string MessageType = "info";
            FileLog(MessageType, message, ConsoleColor.White);
        }
        public virtual void LogWarning(string message)
        {
            string MessageType = "Warning";
            FileLog(MessageType, message, ConsoleColor.Yellow);
        }
        public virtual void LogError(string message)
        {
            string MessageType = "Error";
            FileLog(MessageType, message, ConsoleColor.Red);
        }

        public void FileLog( string messagetype, string message, ConsoleColor color)
        {

            string fileName = " ";
            switch (color)
            {
                case ConsoleColor.White:
                    fileName = "info.log";
                    break;
                case ConsoleColor.Yellow:
                    fileName = "warning.log";
                    break;
                case ConsoleColor.Red:
                    fileName = "error.log";
                    break;
            }
            var fileWriter = new StreamWriter(fileName);
            fileWriter.WriteLine($"{DateTime.Now:yyyy-MM-dd-hh:mm:ss}\t" + messagetype + "\t" + message);
            fileWriter.Close();
        }
       
        }

    }

