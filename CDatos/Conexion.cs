using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;


namespace CDatos
{
    public class Conexion
    {

        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
            public SqlConnection sqlConnection = new SqlConnection(cadena);


        public void OpenConnection()
        {
            sqlConnection.Open();
        }

        public void CloseConnection()
        {
            sqlConnection.Close();
        }
    }
}
