

using DbConnect;

namespace ConsoleApp1
{
    public class ConsoleApp1
    {

        public static void Main(string[] args)
        {
            DbConnection sqlConnection = new SqlConnection("sqlServer://user:password/localhost:27017/SqlDb", new TimeSpan(20));
            //sqlConnection.Open();
            DbCommand dbCommand = new DbCommand(sqlConnection, "SELECT * From BlogApi.Articles");
            dbCommand.Execute();


            DbConnection oracleConnection = new OracleConnection("oracleServer://user:password/localhost:27017/OracleDb", new TimeSpan(20));
            DbCommand dbCommand1 = new DbCommand(oracleConnection, "SELECT * From BlogApi.Articles");
            dbCommand1.Execute();
        }
    }
}