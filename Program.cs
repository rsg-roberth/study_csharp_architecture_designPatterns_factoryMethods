using study_csharp_architecture_designPatterns_factoryMethods._1_AbstractCreator;
using System;

namespace study_csharp_architecture_designPatterns_factoryMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutionFactoryMethod.Run();
            Console.WriteLine("Hello World!");
        }
    }

    public class ExecutionFactoryMethod
    {
        public static void Run()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer).CreateConnector("myCS").Connect();
            sqlCn.ExecuteCommand("select * from tableSQl");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.Database(DataBase.Oracle).CreateConnector("minhaCS").Connect();
            oracleCn.ExecuteCommand("select * from tabelaOracle");
            oracleCn.Close();
        }
    }
}
