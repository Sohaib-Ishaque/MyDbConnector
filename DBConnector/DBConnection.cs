using System;

namespace DBConnector
{
    public abstract class DBConnection
    {
        private protected readonly string _connectionString;
        public virtual TimeSpan Timeout { get; set; }

        public DBConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Connection String is required.");

            this._connectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
