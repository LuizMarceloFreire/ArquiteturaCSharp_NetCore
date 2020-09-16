using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._2___Facade.CrossCuting
{
    public interface IConfigurationManager
    {
        string GetValue(string node);
    }
}
