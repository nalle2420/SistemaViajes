using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;

namespace CNegocios
{
    public class CNTransportista
    {
        private CDTransportista objTr = new CDTransportista();


        public List<Transportistas> Listar()
        {
            return objTr.Listar();
        }
    }
}
