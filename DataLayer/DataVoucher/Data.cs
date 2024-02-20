using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Cursor;
using MySqlX.XDevAPI;
using System;
using System.Data;

namespace DataLayer.DataVoucher
{
    public class Data
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost; DATABASE=bdaltiplano; UID=root;PASSWORD= ;");

        public bool IsDatabaseConnected()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public object getTable(string[] ftdate)
        {
            DataTable dataTable = new DataTable();

            if (!IsDatabaseConnected())
            {
                string error = "No tiene acceso a la base de datos";
                return error;
            }

            string sqlQuery = "SELECT id_task, user AS USUARIO,  inspect AS INSPECCIONADO,"
                + "cu.clie_cliente AS CLIENTE, date_voucher AS FECHA, "
                + " serie_num AS SERIE_NUM, type AS TIPO, status AS ESTADO " 
                + "FROM tasks_wh JOIN customer AS cu ON  cu.cod_cliente = tasks_wh.client";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@from_dv_", ftdate[0]);
                adapter.SelectCommand.Parameters.AddWithValue("@to_dv_", ftdate[1]);
                adapter.Fill(dataTable);
            }
            Console.WriteLine(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}
