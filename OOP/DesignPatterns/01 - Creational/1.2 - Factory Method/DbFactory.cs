using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public abstract class DbFactory
    {
        //Factory Method

        public abstract DbConnector CreateConnector(string connetionString);

        public static DbFactory Database(DataBase dataBase)
        {
            if(dataBase == DataBase.SqlServer)
             return new SqlFactory();

            if(dataBase == DataBase.Oracle)
             return new OracleFactory();

            throw new ApplicationException("Banco de dados não encontrado");
        }
    }
}
