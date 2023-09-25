using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class Transportistas
    {
        public int Trp_ID { get; set; }
        public string Trp_Nombre { get; set; }
        public string Trp_Apellido { get; set; }

        public string Trp_NombreCompleto { get; set; }
        public string Trp_Telefono { get; set; }
        public decimal Trp_Tarifa { get; set; }
   
    }
}
