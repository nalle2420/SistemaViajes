using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CEntidades;
using System.Collections;

namespace CDatos
{
    public class CDUsuarios
    {  
        public Conexion conec= new Conexion();
        
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();
            
            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("MostrarPacientes", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Usuarios()
                        {
                            Usu_ID = Convert.ToInt32(reader["Usu_ID"]),
                            Usuario = Convert.ToString(reader["Usuario"]),
                            Usu_clave = Convert.ToString(reader["Usu_clave"]),
                            Emp_ID = Convert.ToInt32(reader["Emp_ID"]),
                            Usu_activo = Convert.ToBoolean(reader["Usu_activo"])
                        });
                        
                    }
                }
            }
            catch (Exception ex){
                lista = new List<Usuarios>();
            }
            finally
            {
                conec.CloseConnection();
            }
            return lista;
        }

        public Usuarios BuscarUsuario(string nomUsuario) { 
          Usuarios usu = new Usuarios();
            conec.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("BuscarUsuario", conec.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Usuario", nomUsuario);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        usu.Usu_ID = Convert.ToInt32(reader["Usu_ID"]);
                        usu.Usuario = Convert.ToString(reader["Usuario"]);
                        usu.Usu_clave = Convert.ToString(reader["Usu_clave"]);
                        usu.Emp_ID = Convert.ToInt32(reader["Emp_ID"]);
                        usu.Usu_activo = Convert.ToBoolean(reader["Usu_activo"]);
                        

                    }
                }
            }
            catch (Exception ex)
            {
                usu = null;
            }
            finally
            {
                conec.CloseConnection();
            }
            return usu;
        }
    }
}
