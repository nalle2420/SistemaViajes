using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class Viajes
    {
        public int Viaje_ID { get; set; }
        public Empleados oEmpleado { get; set; }
        public Sucursal oSucursal { get; set; }
        public DateTime Viaje_Fecha { get; set; }
        public Transportistas oTransportista { get; set; }

        public List<Viaje_Detalles> oViajeDetalle { get; set; }
        public int Viaje_Total { get; set; }
    }
}
