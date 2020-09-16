using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._1___Adapter
{
    //Classe Adapter
    public class LogAdapter : ILogger
    {
        private readonly ILoggerNetMaster _loggerNetMaster;

        public LogAdapter(ILoggerNetMaster loggerNetMaster)
        {
            _loggerNetMaster = loggerNetMaster;
        }

        public void Log(string message)
        {
            _loggerNetMaster.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _loggerNetMaster.LogException(exception);
        }
    }
}
