﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataManager
{
    public class StatusTable
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost; DATABASE=bdaltiplano; UID=root;PASSWORD= ;");

        public void updatedStatusS(object[] valClickRowView)
        {
            int newstatus = 0;

            if (valClickRowView[2].Equals("ACTIVO"))
            {
                newstatus = 0;
            }
            if (valClickRowView[2].Equals("NO ACTIVO"))
            {
                newstatus = 1;
            }

            Console.WriteLine("" + newstatus);

            connection.Open();
            string sqlQuery = "UPDATE seller_status_wh SET status = @newstatus WHERE id = @n_";

            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
            {
                Console.WriteLine("UPDATE seller_status_wh SET status = " + newstatus + " WHERE id = " + valClickRowView[0]);
                cmd.Parameters.AddWithValue("@newstatus", newstatus);
                cmd.Parameters.AddWithValue("@n_", valClickRowView[0]);

                cmd.ExecuteNonQuery();
            }

            connection.Close() ;
        }

        public void updatedStatusP(object[] valClickRowView)
        {
            int newstatus = 0;

            if (valClickRowView[2].Equals("ACTIVO"))
            {
                newstatus = 0;
            }else if (valClickRowView[2].Equals("NO ACTIVO"))
            {
                newstatus = 1;
            }

            connection.Open();
            string sqlQuery = "UPDATE payment_status_wh SET status = @newstatus WHERE id = @n_";

            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
            {
                cmd.Parameters.AddWithValue("@newstatus", newstatus);
                cmd.Parameters.AddWithValue("@n_", valClickRowView[0]);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
