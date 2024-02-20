using DataLayer.Reposit;
using MySql.Data.MySqlClient;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLogin
{
    public class LoginClass
    {
        private readonly DataBase dataBase = new DataBase();

        Boolean answer = false;

        public Boolean Login(string username, string password) 
        {
            MySqlConnection connection = dataBase.dbconnection();

            int exist = 0;

            string sqlQuery = "SELECT COUNT(*) FROM usuario "
                + "WHERE usua_nick = @username "
                + "AND usua_clave = @password AND cod_perfil = 2";
            
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
