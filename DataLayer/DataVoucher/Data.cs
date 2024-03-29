﻿using DataLayer.Reposit;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DataLayer.DataVoucher
{
    public class Data
    {
        private readonly DataBase dataBase = new DataBase();

        public bool IsDatabaseConnected()
        {
            MySqlConnection connection = dataBase.dbconnection();

            try
            {
               connection.Open();
               return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               return false;
            }
        }

        public object getTable(string[] ftdate)
        {
            MySqlConnection connection = dataBase.dbconnection();

            DataTable dataTable = new DataTable();

            if (!IsDatabaseConnected())
            {
                string error = "No tiene acceso a la base de datos";
                return error;
            }
            connection.Open();
            string sqlQuery = "SELECT id_task, user AS USUARIO, inspect AS INSPECCIONADO,"
                              + " cu.clie_cliente AS CLIENTE, date_voucher AS FECHA, "
                              + " serie_num AS SERIE_NUM, type AS TIPO, status AS ESTADO "
                              + "FROM tasks_wh JOIN customer AS cu ON cu.cod_cliente = tasks_wh.client "
                              + "WHERE DATE(date_voucher) >= @from_dv_ AND DATE(date_voucher) <= @to_dv_ "
                              + "ORDER BY CASE WHEN status = 'SIN INICIAR' THEN 0 WHEN status = 'PROCESO' THEN 1 ELSE 2 END";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@from_dv_", ftdate[0]);
                    adapter.SelectCommand.Parameters.AddWithValue("@to_dv_", ftdate[1]);
                    adapter.Fill(dataTable);
                }

            connection.Close();
            return dataTable;
        }
    }
}
