using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._2___Factory_Method
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer)
                .CreateConnector("minha conexão")
                .Connect();

            sqlCn.ExecuteCommand("select * from tabelaSQL");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.Database(DataBase.Oracle)
                .CreateConnector("minha conexão")
                .Connect();

            oracleCn.ExecuteCommand("select * from tabelaOracle");
            oracleCn.Close();
        }
    }
}
