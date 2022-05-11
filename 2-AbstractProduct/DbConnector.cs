namespace study_csharp_architecture_designPatterns_factoryMethods._2_AbstractProduct
{
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }
        public abstract Connection Connect();
    }
}
