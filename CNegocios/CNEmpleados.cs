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
        public List<Empleados> Listar()
        {
            
            return objEmpleado.Listar();
        }

        public List<Empleados> BuscarEmpxSucursal(int id)
        {
            return objEmpleado.BuscarEmpleadosxSucursal(id);
        }

        public int EmpleadoxFechal(int id)
        {
            return objEmpleado.FechaEmpleado(id);
        }


    }
}
