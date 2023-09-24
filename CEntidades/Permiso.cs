using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class Permiso
    {
        public int Permiso_ID { get; set; }

        public Puesto oPuesto { get; set; }

        public string NombreMenu { get; set; }

    }
}
