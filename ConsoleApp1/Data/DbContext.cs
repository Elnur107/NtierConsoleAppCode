using System.Data.SqlClient;

namespace NtierConsoleApp.Data
{
    public class DbContext
    {
        private readonly string connectionString;

        public DbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
