using DataLayer.Reposit;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataVoucher.Updated
{
    public class UpdatedClass
    {
        private readonly DataBase dataBase = new DataBase();

        public DataTable waiting(int option, int id, string user, string inspect)
        {
            MySqlConnection connection = dataBase.dbconnection();

            DataTable dataTable = new DataTable();

            if(option == 1)
            {
                string sqlQuery = "UPDATE tasks_wh SET user = @user_ , date_start = NOW(), status = 'PROCESO' WHERE id_task = @id_t_;";

                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@user_", user);
                    cmd.Parameters.AddWithValue("@id_t_", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }

            }
            else if(option == 2)
            {
                string sqlQuery = "UPDATE tasks_wh SET inspect = @inspect_ , date_end = NOW(), status = 'FINALIZADO' WHERE id_task = @id_t_;";

                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@inspect_", inspect);
                    cmd.Parameters.AddWithValue("@id_t_", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
