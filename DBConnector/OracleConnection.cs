using System;

namespace DBConnector
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            base.Timeout = TimeSpan.FromSeconds(120);
        }

        public override void Close()
        {
            Console.WriteLine("Closing connection to Oracle...");
        }

        public override void Open()
        {
            Console.WriteLine("Opening connection to Oracle...");
            Console.WriteLine($"Timeout is set to {base.Timeout}");
        }
    }
}
