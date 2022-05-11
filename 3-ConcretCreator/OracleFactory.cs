using study_csharp_architecture_designPatterns_factoryMethods._1_AbstractCreator;
using study_csharp_architecture_designPatterns_factoryMethods._2_AbstractProduct;
using study_csharp_architecture_designPatterns_factoryMethods._4_ConcretProduct;

namespace study_csharp_architecture_designPatterns_factoryMethods._3_ConcretCreator
{
    public class OracleFactory : DbFactory
    {
        //Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
