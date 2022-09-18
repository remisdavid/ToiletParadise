using System.Data.SqlClient;
using ToiletParadise.Database;

namespace ToiletParadise.Models
{
    public class Toilets
    {
        public List<Toilet> toilets = new List<Toilet>();

        public void Load()
        {
            string query = "SELECT [ID] FROM [dbo].[Toilet]";
            SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                toilets.Add(new Toilet(reader.GetInt32(0)));
            }
            reader.Close();

        }

    }
}
