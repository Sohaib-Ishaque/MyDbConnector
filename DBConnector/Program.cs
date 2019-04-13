using System;

namespace DBConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("My.SQL.ConnectionString");
            var sqlCommand = new DBCommand(sqlConnection, "DROP TABLE tblUsers -- On SQL Server");
            sqlCommand.Execute();

            var oracleConnection = new OracleConnection("My.Oracle.ConnectionString");
            var oracleCommand = new DBCommand(oracleConnection, "DROP TABLE tblUsers -- On Oracle");
            oracleCommand.Execute();

            try
            {
                var fakeSQLConnection = new SqlConnection("fasdf");
                var fakeSQLCommand = new DBCommand(fakeSQLConnection, null);
                fakeSQLCommand.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    }
