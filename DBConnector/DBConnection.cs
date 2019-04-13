using System;

namespace DBConnector
{
    public class DBConnection
    {
        private readonly string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DBConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Connection String is required.");

            this._connectionString = connectionString;
        }

        public virtual void Open()
        {
            var startTime = DateTime.Now;

            // connection code would go here...

            var endTime = DateTime.Now;

            CheckTimeout(startTime, endTime);
        }

        public virtual void Close()
        {
        }

        private void CheckTimeout(DateTime startTime, DateTime endTime)
        {
            if (endTime - startTime >= this.Timeout)
                throw new TimeoutException("The connection timed out...");
        }
    }
}
