using System;

namespace study_csharp_architecture_designPatterns_factoryMethods
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection( string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executing command: " + command);
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Open connection");
        }

        public void Close()
        {
            Console.WriteLine("Close connection");
        }
    }
}
