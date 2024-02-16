﻿using MySql.Data.MySqlClient;
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

        MySqlConnection connection = new MySqlConnection("SERVER=localhost; DATABASE=warehouse; UID=root;PASSWORD= ;");

        public DataTable getUserCountAmount()
        {

            connection.Open();
            DataTable dataTable = new DataTable();

            string sqlQuery = "SELECT  ROW_NUMBER() OVER (ORDER BY SUM(amount) DESC) AS ID,   user AS USUARIO,    COUNT(*) AS CANTIDAD,    SUM(amount) AS IMPORTE FROM    tasks_gc WHERE   status = 'FINALIZADO'   AND MONTH(date_end) = MONTH(CURRENT_DATE)   AND YEAR(date_end) = YEAR(CURRENT_DATE) GROUP BY    user ORDER BY    IMPORTE DESC, CANTIDAD DESC;";

            using (MySqlDataAdapter adapter =  new MySqlDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataTable);
            }
            connection.Close();

            return dataTable;
        }

        public DataTable getSeller()
        {
            connection.Open();
            DataTable dataTable = new DataTable();

            string sqlQuery = "SELECT ss.id AS ID, name AS NOMBRE, CASE WHEN ss.status = 1 THEN 'ACTIVO' ELSE 'NO ACTIVO' end as ESTADO FROM statusseller_gc AS ss JOIN people_gc AS p ON p.id = ss.id WHERE p.id_profile = 2";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataTable);
            }
            connection.Close ();

            return dataTable;
        }

        public DataTable getPayment() 
        {
            connection.Open();
            DataTable dataTable = new DataTable();

            string sqlQuery = "SELECT id_payment AS ID, description AS CAJA, CASE WHEN status = 1 THEN 'ACTIVO' WHEN status = 0 THEN 'NO ACTIVO' ELSE 'NO ACTIVO' END AS ESTADO FROM payment_gc;";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
            {
                adapter.Fill(dataTable);
            }
            connection.Close () ;

            return dataTable;
        }
    }
}