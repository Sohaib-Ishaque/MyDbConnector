using System;

namespace DBConnector
{
    public class DBCommand
    {
        private readonly DBConnection _dBConnection;
        private readonly string _sql;

        public DBCommand(DBConnection dBConnection, string sql)
        {
            _dBConnection = dBConnection ?? throw new InvalidOperationException("DBConnection required.");
            this._sql = sql ?? throw new InvalidOperationException("sql required.");
        }

        public void Execute()
        {
            _dBConnection.Open();
            Console.WriteLine($"Executing: {_sql}");
            _dBConnection.Close();
        }
    }
}
