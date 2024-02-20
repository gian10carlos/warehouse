using DataLayer.Reposit;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataManager
{
    public class Data
    {

        private readonly DataBase dataBase = new DataBase();

        public Boolean changeValMin(int num)
        {
            MySqlConnection connection = dataBase.dbconnection();
            
            Boolean valResult = false;
            connection.Open();

            string sqlQuery = "UPDATE valMin_wh SET amount = @num ORDER BY id LIMIT 1;";

            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
            {
                cmd.Parameters.AddWithValue("@num", num);

                int result =  cmd.ExecuteNonQuery();

                if(result > 0)
                {
                    valResult = true;
                }
                else
                {
                    valResult= false;
                }
            }
            connection.Close();
            return valResult;
        }

        public DataSet getScoreQuantity()
        {
            MySqlConnection connection = dataBase.dbconnection();

            connection.Open();
            DataSet dataSet = new DataSet();

            string sqlQuery = "SELECT user AS USUARIO, COUNT(*) AS CANTIDAD, SUM(amount) "
                + " AS IMPORTE FROM tasks_wh WHERE status = 'FINALIZADO'"
                + " AND DATE(date_end) = CURRENT_DATE GROUP BY user ORDER BY IMPORTE DESC,"
                + " CANTIDAD DESC LIMIT 5;";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                {
                    adapter.Fill (dataSet);
                }
                connection.Close ();
                return dataSet;
        }
    }
}
