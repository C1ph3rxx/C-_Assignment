using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnect
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void Close()
        {
            Console.WriteLine($"Closing Oracle database connection....");
        }

        public override void Open()
        {
            Console.WriteLine($"Opening Oracle database connection....");
        }
    }
}
