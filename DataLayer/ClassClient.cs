using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataLayer
{
    public class ClassClient
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        public List<string> getNameAll()
        {
            List<string> names = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string storedProcedure = "list_people";
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["NOMBRE"].ToString();
                            names.Add(name);
                        }
                    }
                }
                return names;
            }
        }
    }
}
