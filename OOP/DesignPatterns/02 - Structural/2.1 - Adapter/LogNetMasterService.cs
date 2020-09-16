using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._1___Adapter
{
    //Classe Adaptee
    public class LogNetMasterService : ILoggerNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log customizado - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Log customizado - " + exception.Message);
        }
    }
}
