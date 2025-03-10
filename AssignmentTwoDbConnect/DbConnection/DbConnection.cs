using System.Data;
using System.Data.Common;

namespace DbConnect
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeout;


        public DbConnection(string connectionString, TimeSpan timeout)
        {
            if (string.IsNullOrWhiteSpace(connectionString) || string.IsNullOrEmpty(connectionString) || connectionString.GetType().Name is not "String")
            {
                throw new ArgumentException("Connection string cannot be null or empty.");
            }

            _connectionString = connectionString;
            _timeout = timeout;


        }

        public abstract void Open();

        public abstract void Close();

    }
}
