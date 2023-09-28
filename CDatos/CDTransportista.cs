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
    public class CDTransportista
    {
        public Conexion conec = new Conexion();

        public List<Transportistas> Listar() //lista todos los transportistas
        {
            List<Transportistas> lista = new List<Transportistas>();

            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("ObtenerTransportistas", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Transportistas()
                        {
                            Trp_ID = Convert.ToInt32(reader["Trp_ID"]),
                            Trp_Nombre = Convert.ToString(reader["Trp_Nombre"]),
                            Trp_Apellido = Convert.ToString(reader["Trp_Apellido"]),
                            Trp_Telefono= Convert.ToString(reader["Trp_Telefono"]),
                            Trp_Tarifa = Convert.ToDecimal(reader["Trp_Tarifa"])
                        });

                    }
                }
                foreach (Transportistas transportista in lista)
                {
                    transportista.Trp_NombreCompleto = transportista.Trp_Nombre + " " + transportista.Trp_Apellido;
                }
            }
            catch (Exception ex)
            {
                lista = new List<Transportistas>();
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
