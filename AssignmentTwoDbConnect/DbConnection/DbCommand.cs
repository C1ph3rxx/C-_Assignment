using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnect
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _dbCommand;

        public DbCommand(DbConnection dbConnection, string dbCommand)
        {
            ArgumentNullException.ThrowIfNull(dbConnection);
            if (string.IsNullOrEmpty(dbCommand) || string.IsNullOrWhiteSpace(dbCommand))
            {
                throw new ArgumentNullException(dbCommand);
            }

            _dbConnection = dbConnection;
            _dbCommand = dbCommand;
            
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Executing command: {_dbCommand}");
            _dbConnection.Close();
            Console.WriteLine("\n");
        }
    }
}
