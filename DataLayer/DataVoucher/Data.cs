
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataVoucher
{
    public class Data
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost; DATABASE=bdaltiplano; UID=root;PASSWORD= ;");

        public DataTable getTable()
        {
            DataTable dataTable = new DataTable();

            string sqlQuery = "SELECT id_task,user AS USUARIO, inspect AS INSPECCIONADO, client AS CLIENTE, date_voucher AS FECHA, serie_num AS SERIE_NUM, type AS TIPO, status AS ESTADO " +
                              "FROM tasks_gc " +
                              "WHERE status = 'SIN INICIAR' OR status = 'PROCESO' " +
                              "ORDER BY CASE WHEN status = 'SIN INICIAR' THEN 0 WHEN status = 'PROCESO' THEN 1 ELSE 2 END";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
