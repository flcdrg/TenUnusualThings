using System.Data.SqlClient;

namespace CodeAware
{
    // http://blogs.msdn.com/b/vbteam/archive/2015/05/01/roslyn-ships-v1.0-rc2-with-go-live-license.aspx
    public class Class1
    {
        private SqlConnection _connection;

        public Class1()
        {
            _connection = new SqlConnection();
        }
    }
}
