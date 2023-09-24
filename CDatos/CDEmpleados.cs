using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CEntidades;

namespace CDatos
{
    public class CDEmpleados
    {
        public Conexion conec = new Conexion();

        public Empleados BuscarEmpleado(int id)
        {
            Empleados emp = new Empleados();
            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("BuscarEmpleado", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emp_ID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        emp.Emp_ID = Convert.ToInt32(reader["Emp_ID"]);
                        emp.Emp_Nombre = Convert.ToString(reader["Emp_Nombre"]);
                        emp.Emp_Apellido = Convert.ToString(reader["Emp_Apellido"]);


                    }
                }
            }
            catch (Exception ex)
            {
                emp = null;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conec.CloseConnection();
            }
            return emp;
        }
    }
}
