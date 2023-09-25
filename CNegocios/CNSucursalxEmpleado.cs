using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;

namespace CNegocios
{
    public class CNSucursalxEmpleado
    {
        private CDSucursalxEmpleado objSuxEmp = new CDSucursalxEmpleado();

        public List<SucursalxEmpleado> BuscarSucursalxEmp(int id)
        {
            return objSuxEmp.BuscarSucursalxEmpleado(id);
        }

        public string AgregarSucursalxEmp(SucursalxEmpleado registro)
        {
            return objSuxEmp.AgregarSucursalXEmpleado(registro);
        }
        
            
    }
}
