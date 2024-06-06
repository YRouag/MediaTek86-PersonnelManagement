using System.Configuration;

namespace MediaTek86.dal
{
    public static class Connection
    {
        private static string connectionString;

        static Connection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}
