using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public  class Reporte
    {
        public int Viaje_ID { get; set; }
        public string NombreEmpleado { get; set;}

        public string NombreCompleto { get; set; }

        public string ApellidoEmpleado { get; set;}

        public string NombreSucursal { get; set;}

        public DateTime Fecha { get; set;}

        public int ViajeTotal { get; set;}

        public decimal TotalCalculado { get; set;}



    }
}
