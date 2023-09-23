using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class Usuarios
    {
        public int Usu_ID { get; set; }
        public string Usuario { get; set;}
        public string Usu_clave { get; set;}
        public Empleados oEmpleado { get; set;}
        public bool Usu_activo { get; set;}
    
    }
}
