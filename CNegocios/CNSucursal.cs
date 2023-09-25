using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;

namespace CNegocios
{
    public class CNSucursal
    {
        private CDSucursales objSu = new CDSucursales();

        public List<Sucursal> BuscarSucursalNoVinc(int id)
        {
            return objSu.BuscarSucursalNoVinculada(id);
        }

        public List<Sucursal> Listar()
        {
            return objSu.Listar();
        }

    }
}
