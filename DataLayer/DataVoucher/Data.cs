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

            string sqlQuery = "SELECT id_task, user AS USUARIO, inspect AS INSPECCIONADO, "
                             + "client AS CLIENTE, date_voucher AS FECHA, serie_num AS SERIE_NUM, "
                             + "type AS TIPO, status AS ESTADO "
                             + "FROM tasks_gc "
                             + "WHERE DATE(date_voucher) >= @from_dv_ AND DATE(date_voucher) <= @to_dv_ "
                             + "ORDER BY CASE WHEN status = 'SIN INICIAR' THEN 0 WHEN status = 'PROCESO' THEN 1 ELSE 2 END";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@from_dv_", ftdate[0]);
                adapter.SelectCommand.Parameters.AddWithValue("@to_dv_", ftdate[1]);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
