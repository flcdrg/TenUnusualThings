using System.Data.SqlClient;

namespace CodeAware
{
    public class Class1
    {
        private SqlConnection _connection;

        public Class1()
        {
            _connection = new SqlConnection();
        }
    }
}
