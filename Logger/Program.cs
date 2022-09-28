using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogWriter fileLog = new FileLogWriter();
            ConsoleLogWriter consoleLog = new ConsoleLogWriter();
            fileLog.LogInfo("Информация");
            consoleLog.LogInfo("Информация");
            fileLog.LogWarning("Предупреждение");
            consoleLog.LogWarning("Предупреждение");
            fileLog.LogError("Ошибка");
            consoleLog.LogError("Ошибка");
        }
    }
}
