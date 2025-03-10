using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnect
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void Close()
        {
            Console.WriteLine($"Closing Sql database connection....");
        }

        public override void Open()
        {

            Console.WriteLine($"Opening Sql database connection....");
        }
    }
}
