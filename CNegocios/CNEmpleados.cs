using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;

namespace CNegocios
{
    public class CNEmpleados
    {
        private CDEmpleados objEmpleado = new CDEmpleados();

        public Empleados BuscarEmpleado(int id)
        {
            return objEmpleado.BuscarEmpleado(id);

        }
    }
}
