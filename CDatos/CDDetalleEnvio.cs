using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CEntidades;
using System.Security.Policy;

namespace CDatos
{
    public class CDDetalleEnvio
    {
        public Conexion conec = new Conexion();
        public void AgregarDetalle(Viaje_Detalles detalles) // envia a insertar los detalles de un viaje
        {
            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("InsertarDetalleViaje", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Viaje_ID", detalles.VD_ID);
                command.Parameters.AddWithValue("@Emp_ID", detalles.oEmpleado.Emp_ID);
                command.Parameters.AddWithValue("Distancia_KM", detalles.Distancia_KM);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conec.CloseConnection();
            }

        }
    }
}
