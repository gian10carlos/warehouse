using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace DataLayer
{
    public class ClassData
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        public List<string> getReceiptAll()
        {
            List<string> receipts = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string storedProcedure = "list_receipt";
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string receipt = reader["RECEIPT"].ToString();
                            receipts.Add(receipt);
                        }
                    }
                }
                return receipts;
            }
        }

        public void AddTask(string client, string receipt, string type, string date, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string storedProcedure = "add_task";
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@name", "GIAN");
                    cmd.Parameters.AddWithValue("@client", client);
                    cmd.Parameters.AddWithValue("@receipt", receipt);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@date_start", DateTime.Now);
                    cmd.Parameters.AddWithValue("@date_end", DateTime.Now);
                    cmd.Parameters.AddWithValue("@status", status);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public DataTable getTable(string name)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string storedProcedure = "get_tasks";
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //USERNAME FORM1
                    //cmd.Parameters.AddWithValue("@name", "GIAN");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                } 
            }

            return dataTable;
        }

        public string getStatus(int id)
        {
            string newStatus =  string.Empty;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string storedProcedure = "update_status";
                using (SqlCommand cmd  = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskId", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            newStatus = reader["NEW_STATUS"].ToString();
                        }
                    }
                }
            }
            return newStatus;
        }

        public void UpdateStatusFinish(int id)
        {
            string newStatus = string.Empty;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string storedProcedure = "update_status_finish";
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateStatusProcess(int id)
        {
            string newStatus = string.Empty;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string storedProcedure = "update_status_process";
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
        }

        public Boolean UserSearch(string user)
        {
            Boolean answerUser = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE name LIKE @user";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", "%" + user + "%");
                    
                    int rowCount  = (int)cmd.ExecuteScalar();
                    answerUser = rowCount > 0;
                }
            }

            return answerUser;
        }

        public void StartTasks(string user, string status, int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string storedProcedure = "start_task";
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@name", user);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
