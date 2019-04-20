using System;

namespace DBConnector
{
    public class SqlConnection : DBConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            base.Timeout = TimeSpan.FromSeconds(60);
        }

        public override void Close()
        {
            Console.WriteLine("Closing connection to SQL Server...");
        }

        public override void Open()
        {
            Console.WriteLine("Opening connection to SQL Server...");
            Console.WriteLine($"Timeout is set to {base.Timeout}");
        }
    }
}
