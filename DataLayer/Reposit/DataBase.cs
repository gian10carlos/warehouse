using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Reposit
{
    internal class DataBase
    {
        string _cadenaConexion;
        public string CadenaConexion
        {

            get
            {
                if (_cadenaConexion == null)
                {
                    _cadenaConexion = ConfigurationManager.ConnectionStrings["connectionMysql"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set { _cadenaConexion = value; }
     
        }

        public MySqlConnection dbconnection()
        {
            MySqlConnection connection = new MySqlConnection(CadenaConexion);
            return connection;
        }
    }
}
