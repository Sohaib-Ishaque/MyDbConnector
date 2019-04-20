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
                var emptyConnectionString = new SqlConnection(string.Empty);
                var emptyCommand = new DBCommand(emptyConnectionString, "DROP TABLE tblUsers;");
                emptyCommand.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var whitespaceConnectionString = new SqlConnection(" ");
                var whitespaceCommand = new DBCommand(whitespaceConnectionString, "DROP TABLE tblUsers;");
                whitespaceCommand.Execute();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                var fakeSQLConnection = new SqlConnection("fasdf");
                var fakeSQLCommand = new DBCommand(fakeSQLConnection, null);
                fakeSQLCommand.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    }
