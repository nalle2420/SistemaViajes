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
    public class CDSucursalxEmpleado
    {
        public Conexion conec = new Conexion();

        public List<SucursalxEmpleado> BuscarSucursalxEmpleado(int id)
        {
            List<SucursalxEmpleado> lista = new List<SucursalxEmpleado>();

            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("ObtenerSucursales", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emp_ID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new SucursalxEmpleado()
                        {

                            oSucursal = new Sucursal() { Sucursal_ID = Convert.ToInt32(reader["Sucursal_ID"]), sucursal = Convert.ToString(reader["Sucursal"]) },
                            oEmpleado = new Empleados() { Emp_ID = id },
                            Distancia_KM = Convert.ToInt32(reader["Distancia_KM"]),

                        });

                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<SucursalxEmpleado>();
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                conec.CloseConnection();
            }
            return lista;
        }


        public string AgregarSucursalXEmpleado(SucursalxEmpleado relacion)
        {
            string mensaje = null;
            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("AgregarEmpleadoxSucursal", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emp_ID", relacion.oEmpleado.Emp_ID);
                command.Parameters.AddWithValue("Sucursal_ID", relacion.oSucursal.Sucursal_ID);
                command.Parameters.AddWithValue("Distancia_KM", relacion.Distancia_KM);
                command.ExecuteNonQuery();
                mensaje = "Agregado Exitosamente";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "Ocurrio un error al insertar el dato";

            }
            finally
            {
                conec.CloseConnection();
            }

            if (mensaje != null)
            {
                return mensaje;
            }
            else
            {
                return "Ocurrio un error al insertar el dato";
            }
        }

        

            
        }
    }

