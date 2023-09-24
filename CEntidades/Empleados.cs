using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class Empleados
    {
        public int Emp_ID { get; set; }

        public string Emp_identidad { get; set; }

        public string Emp_Nombre { get; set; }

        public string Emp_Apellido { get; set; }

        public string Emp_NomCompleto { get; set; }

        public string Emp_Direccion { get; set; }

        public string Emp_Telefono { get; set; }

        public Puesto oPuesto { get; set; }

        public bool Emp_transporte { get; set; }

        
    }
}
