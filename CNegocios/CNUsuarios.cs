using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;

namespace CNegocios
{
    public class CNUsuarios
    {
        private CDUsuarios objUsuario = new CDUsuarios();

        public List<Usuarios> Listar()
        {
            return objUsuario.Listar();
        }

        public Usuarios BuscarUsuario(string nomUsu)
        {
            return objUsuario.BuscarUsuario(nomUsu);
            
        }
    }
}
