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
    public class CDViajes
    {
        public Conexion conec = new Conexion();

        public int InsertarViaje(Viajes viaje)
        {
            int confirmacion = 0;
            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("InsertarViaje", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emp_ID", viaje.oEmpleado.Emp_ID);
                command.Parameters.AddWithValue("Sucursal_ID", viaje.oSucursal.Sucursal_ID);
                command.Parameters.AddWithValue("Trp_ID", viaje.oTransportista.Trp_ID);
                command.Parameters.AddWithValue("Viaje_Total", viaje.Viaje_Total);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    confirmacion = Convert.ToInt32(result);
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

    }
}
