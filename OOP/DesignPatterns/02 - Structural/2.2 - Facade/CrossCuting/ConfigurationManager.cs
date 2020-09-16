using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns._02___Structural._2._2___Facade.CrossCuting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string node)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10).Select(x => x[new Random().Next(x.Length)]).ToArray());
        }
    }
}
