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

        MySqlConnection connection = new MySqlConnection("SERVER=localhost; DATABASE=bdaltiplano; UID=root;PASSWORD= ;");
        
        public DataTable waiting(int option,string date_r, int val_min, int id, string user, string inspect)
        {
            DataTable dataTable = new DataTable();

            
            string procesureQuery = "operationTask_gc";

            using (MySqlCommand cmd = new MySqlCommand(procesureQuery, connection))
            { 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("@option_", MySqlDbType.Int32)).Value = option;
                cmd.Parameters.Add(new MySqlParameter("@date_r_", MySqlDbType.VarString, 500)).Value = date_r;
                cmd.Parameters.Add(new MySqlParameter("@val_min_", MySqlDbType.VarString, 500)).Value = val_min;
                cmd.Parameters.Add(new MySqlParameter("@id_t_", MySqlDbType.Int32)).Value = id;
                cmd.Parameters.Add(new MySqlParameter("@user_", MySqlDbType.VarString, 500)).Value = user;
                cmd.Parameters.Add(new MySqlParameter("@inspect_", MySqlDbType.VarString, 500)).Value = inspect;

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
