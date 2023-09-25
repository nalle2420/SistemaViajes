using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;

namespace CNegocios
{
    public class CNDetalleViaje
    {
        private CDDetalleEnvio objdetalles = new CDDetalleEnvio();

        public void InsertarNuevoDetalle(Viaje_Detalles viaje)
        {
            objdetalles.AgregarDetalle(viaje);
        }
    }
}
