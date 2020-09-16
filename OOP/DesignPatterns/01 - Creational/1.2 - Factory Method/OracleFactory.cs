using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    //Concrete Creator
    public class OracleFactory : DbFactory
    {
        //Fctory Method
        public override DbConnector CreateConnector(string connetionString)
        {
            return new OracleDbConnector(connetionString);
        }
    }
}
