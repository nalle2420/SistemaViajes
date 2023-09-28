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

        public Empleados BuscarEmpleado(int id) //busca un empleado segun su id y retorna un objeto tipo empleado
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

        public int FechaEmpleado(int id) // confirma si un empleado ya hizo un viaje ese dia
        {
            int confirmacion = 0;
            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("VerificarEmpleadoFecha", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emp_ID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        confirmacion = Convert.ToInt32(reader["RealizoViaje"]);

                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conec.CloseConnection();
            }
            return confirmacion;
        }


        public List<Empleados> Listar() //obtiene lista de empleados que si utilizan servicio de transporte
        {
            List<Empleados> lista = new List<Empleados>();

            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("ObtenerEmpleadosConTransporte", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Empleados()
                        {
                            Emp_ID = Convert.ToInt32(reader["Emp_ID"]),
                            Emp_Nombre = Convert.ToString(reader["Emp_Nombre"]),
                            Emp_Apellido = Convert.ToString(reader["Emp_Apellido"]),
                           
                    });

                    }
                }
                foreach (Empleados empleados in lista)
                {
                    empleados.Emp_NomCompleto = empleados.Emp_Nombre + " " + empleados.Emp_Apellido;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Empleados>();
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conec.CloseConnection();
            }
            return lista;
        }

        public List<Empleados> BuscarEmpleadosxSucursal(int id) //busca empleados afiliados a una sucursal
        {
            List<Empleados> lista = new List<Empleados>();

            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("ObtenerEmpleadosPorSucursal", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Sucursal_ID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Empleados()
                        {
                            Emp_ID= Convert.ToInt32(reader["Emp_ID"]),
                            Emp_Nombre = Convert.ToString(reader["Emp_Nombre"]),
                            Emp_Apellido = Convert.ToString(reader["Emp_Apellido"]),
                            Emp_Distancia = Convert.ToInt32(reader["Distancia_KM"]),

                        });


                    }
                }
                foreach (Empleados empleados in lista)
                {
                    empleados.Emp_NomCompleto = empleados.Emp_Nombre + " " + empleados.Emp_Apellido;
                }


            }
            catch (Exception ex)
            {
                lista = new List<Empleados>();
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
