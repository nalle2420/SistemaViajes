using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class SucursalxEmpleado
    {
        public Empleados oEmpleado { get; set; }

        public Sucursal oSucursal { get; set; }

        public int Distancia_KM { get; set; }
    }
}
