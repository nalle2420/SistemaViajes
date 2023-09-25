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
    public class CDSucursales
    {

        public Conexion conec = new Conexion();

        public List<Sucursal> BuscarSucursalNoVinculada(int id)
        {
            List<Sucursal> lista = new List<Sucursal>();

            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("ObtenerSucursalesNoVinculadas", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emp_ID", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Sucursal()
                        {

                            Sucursal_ID = Convert.ToInt32(reader["Sucursal_ID"]),
                            sucursal = Convert.ToString(reader["Sucursal"]),
                            

                        });

                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Sucursal>();
            }
            finally
            {
                conec.CloseConnection();
            }
            return lista;
        }


        public List<Sucursal> Listar()
        {
            List<Sucursal> lista = new List<Sucursal>();

            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("BuscarSucursales", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Sucursal()
                        {
                            Sucursal_ID = Convert.ToInt32(reader["Sucursal_ID"]),
                            sucursal = Convert.ToString(reader["Sucursal"]),

                        });

                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Sucursal>();
            }
            finally
            {
                conec.CloseConnection();
            }
            return lista;
        }

    }
}
