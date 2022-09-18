using System.Data.SqlClient;

namespace ToiletParadise.Database
{
    public static class DatabaseConnection
    {
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();
                sqlConnectionString.DataSource = "38.242.198.55";
                sqlConnectionString.InitialCatalog = "Zachody";
                sqlConnectionString.UserID = "ToiletsServer";
                sqlConnectionString.Password = "skola";
                sqlConnectionString.ConnectTimeout = 30;
                sqlConnectionString.MultipleActiveResultSets = true;
                connection = new SqlConnection(sqlConnectionString.ConnectionString);
                connection.Open();

            }
            return connection;
        }


        public static void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }

        }


    }
}
