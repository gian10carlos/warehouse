using DataLayer.Reposit;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataManager
{
    public class TableClass
    {
        private readonly DataBase dataBase = new DataBase();
        public DataTable getUserCountAmount()
        {
            MySqlConnection connection = dataBase.dbconnection();

            connection.Open();
            DataTable dataTable = new DataTable();

           string sqlQuery = "SELECT  ROW_NUMBER() OVER (ORDER BY SUM(amount) DESC) AS ID,"
                + "  user AS USUARIO,  COUNT(*) AS CANTIDAD,  SUM(amount) AS IMPORTE "
                + "  FROM    tasks_wh  WHERE   status = 'FINALIZADO' "
                + " AND MONTH(date_end) = MONTH(CURRENT_DATE)  AND YEAR(date_end) = YEAR(CURRENT_DATE)"
                + "  GROUP BY    user  ORDER BY    IMPORTE DESC, CANTIDAD DESC;";

            using (MySqlDataAdapter adapter =  new MySqlDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataTable);
            }
            connection.Close();

            return dataTable;
        }

        public DataTable getSeller()
        {
            MySqlConnection connection = dataBase.dbconnection();

            connection.Open();
            DataTable dataTable = new DataTable();

            string sqlQuery = "SELECT ss.id AS ID, u.usua_nick AS NOMBRE_VEND, CASE WHEN ss.status = 1 THEN 'ACTIVO' ELSE 'NO ACTIVO' end as ESTADO FROM seller_status_wh AS ss JOIN usuario AS u ON u.cod_usuario = ss.cod_usuario ORDER BY CASE WHEN ss.status = 1 THEN 0 ELSE 1 END, NOMBRE_VEND;\r\n";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataTable);
            }
            connection.Close ();

            return dataTable;
        }

        public DataTable getPayment() 
        {

            MySqlConnection connection= dataBase.dbconnection();

            connection.Open();
            DataTable dataTable = new DataTable();

            string sqlQuery = "SELECT id AS ID, description AS CAJA, CASE WHEN status = 1 THEN "
                + "'ACTIVO' WHEN status = 0 THEN 'NO ACTIVO' ELSE 'NO ACTIVO' END "
                + " AS ESTADO FROM payment_status_wh;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataTable);
            }
            connection.Close () ;

            return dataTable;
        }

        public int getValMin()
        {
            int result = 0;

            MySqlConnection connection = dataBase.dbconnection ();

            connection.Open();

            string sqlQuery = "SELECT amount FROM valMin_wh WHERE id = 1";

            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connection))
            {
                object resultObj = cmd.ExecuteScalar();

                if(resultObj != null)
                {
                    int.TryParse(resultObj.ToString(), out result);
                }
            }

            return result;
        }
    }
}
