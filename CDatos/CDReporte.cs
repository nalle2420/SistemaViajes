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
    public class CDReporte
    {
        public Conexion conec = new Conexion();

        public List<Reporte> ConsultaReporte(DateTime fecha1, DateTime fecha2, int trp)
        {
            List<Reporte> lista = new List<Reporte>();

            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("ObtenerViajesPorFechaYTransportista", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("FechaInicio", fecha1);
                command.Parameters.AddWithValue("FechaFin", fecha2);
                command.Parameters.AddWithValue("Trp_ID", trp);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Reporte()
                        {
                            Viaje_ID = Convert.ToInt32(reader["Viaje_ID"]),
                            NombreEmpleado = Convert.ToString(reader["NombreEmpleado"]),
                            ApellidoEmpleado = Convert.ToString(reader["ApellidoEmpleado"]),
                            NombreSucursal = Convert.ToString(reader["NombreSucursal"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            ViajeTotal = Convert.ToInt32(reader["ViajeTotal"]),
                            TotalCalculado = Convert.ToInt32(reader["TotalCalculado"])
                        });


                    }
                }
                foreach (Reporte reporte in lista)
                {
                    reporte.NombreCompleto= reporte.NombreEmpleado + " " + reporte.ApellidoEmpleado;
                }


            }
            catch (Exception ex)
            {
                lista = new List<Reporte>();
            }
            finally
            {
                conec.CloseConnection();
            }
            return lista;
        }


    }
}
