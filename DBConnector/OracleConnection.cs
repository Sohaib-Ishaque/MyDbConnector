using System;

namespace DBConnector
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing connection to Oracle...");
        }

        public override void Open()
        {
            base.Open();
            Console.WriteLine("Opening connection to Oracle...");
            Console.WriteLine($"Oracle has no timeout");
        }
    }
}
