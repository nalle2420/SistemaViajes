using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;

namespace CNegocios
{
    public class CNViajes
    {
        private CDViajes objviajes = new CDViajes();

        public int InsertarNuevoViaje(Viajes viaje)
        {
            return objviajes.InsertarViaje(viaje);
        }

    }
}
