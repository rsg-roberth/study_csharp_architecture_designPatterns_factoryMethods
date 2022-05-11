using study_csharp_architecture_designPatterns_factoryMethods._2_AbstractProduct;
using System;

namespace study_csharp_architecture_designPatterns_factoryMethods._4_ConcretProduct
{
    public class OracleConnector : DbConnector
    {
        public OracleConnector(string connectionString):base(connectionString)
        {
            ConnectionString = connectionString;
        }
        
        public override Connection Connect()
        {
            Console.WriteLine("Connecting database Oracle...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
