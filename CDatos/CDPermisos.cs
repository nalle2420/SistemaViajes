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
    public class CDPermisos
    {
        public Conexion conec = new Conexion();

        public List<Permiso> PermisosPorEmpleado(int id) //obtiene lista de los permisos que tiene el usuario
        {
            List<Permiso> lista = new List<Permiso>();

            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("PermisosPorEmpleado", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emp_ID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Permiso()
                        {
                            oPuesto = new Puesto() { Puesto_ID = Convert.ToInt32(reader["Puesto_ID"]) },
                  
                             NombreMenu= Convert.ToString(reader["NombreMenu"]),
                           
                        });

                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Permiso>();
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                conec.CloseConnection();
            }
            return lista;
        }

    }
}
