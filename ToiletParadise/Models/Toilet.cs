using System.Data.SqlClient;
using ToiletParadise.Database;

namespace ToiletParadise.Models
{
    public class Toilet
    {
        private int id;
        private string name;
        private double cost;
        private double posX;
        private double posY;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Cost { get => cost; set => cost = value; }
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }

        public Toilet()
        {
        }

        public Toilet(int id)
        {
            Id = id;
            Load();
        }

        public Toilet(string name, double cost, double posX, double posY)
        {
            Name = name;
            Cost = cost;
            PosX = posX;
            PosY = posY;
        }

        public void Load()
        {
            if (id.Equals(null))
            {
                return;
            }

            string query = "SELECT [Name],[Cost],[PosX],[PosY] FROM [dbo].[Toilet] WHERE [ID] = @ID";
            SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection());
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Name = reader.GetString(0);
            Cost = reader.GetDouble(1);
            PosX = reader.GetDouble(2);
            PosY = reader.GetDouble(3);
            reader.Close();

        }

        public void Save()
        {
            if (Name.Equals(null) || Cost.Equals(null) || PosX.Equals(null) || PosY.Equals(null))
            {
                return;
            }

            string query = "INSERT INTO dbo.Toilet VALUES(@Name,@Cost,@PosX,@PosY)";
            SqlCommand cmd = new SqlCommand(query, DatabaseConnection.GetConnection());
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Cost", Cost);
            cmd.Parameters.AddWithValue("@PosX", PosX);
            cmd.Parameters.AddWithValue("PosY", PosY);
            cmd.ExecuteNonQuery();

        }

    }
}
