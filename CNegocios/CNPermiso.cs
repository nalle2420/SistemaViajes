using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;

namespace CNegocios
{
    public class CNPermiso
    {
        private CDPermisos objPermiso = new CDPermisos();

        public List<Permiso> PermisoPermisosPorEmpleado(int id)
        {
            return objPermiso.PermisosPorEmpleado(id);
        }
    }
}
