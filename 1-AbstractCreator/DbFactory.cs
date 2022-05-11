using study_csharp_architecture_designPatterns_factoryMethods._2_AbstractProduct;
using study_csharp_architecture_designPatterns_factoryMethods._3_ConcretCreator;
using System;

namespace study_csharp_architecture_designPatterns_factoryMethods._1_AbstractCreator
{
    public abstract class DbFactory
    {
        //Factory Method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase dataBase)
        {
            if (dataBase == DataBase.SqlServer) return new SqlFactory();
            if (dataBase == DataBase.Oracle) return new OracleFactory();
            throw new ApplicationException("Unknown database");
        }
    }
}
