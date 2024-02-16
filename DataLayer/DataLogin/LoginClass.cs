using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLogin
{
    public class LoginClass
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost; DATABASE=warehouse; UID=root;PASSWORD= ;");
        Boolean answer = false;

        public Boolean Login(string username, string password) 
        {
            int exist = 0;

            string sqlQuery = "SELECT COUNT(*) FROM profileUser_gc WHERE user = @username AND password = PASSWORD(@password)";
            
            connection.Open();
            
            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Connection = connection;
                exist = Convert.ToInt32(cmd.ExecuteScalar());
            }
            connection.Close();
            if (exist == 1) answer = true;

            return answer;
        }
    }
}
