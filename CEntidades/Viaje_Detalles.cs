using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class Viaje_Detalles
    {
        public int VD_ID { get; set; }
        public Empleados oEmpleado { get; set; }
         
        public int idEmp { get; set; }
        public int Distancia_KM { get; set; }
    }
}
