using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;

namespace CNegocios
{
    public class CNReporte
    {
        private CDReporte objRe = new CDReporte();

        public List<Reporte> ConsultaReporte(DateTime fecha1, DateTime fecha2, int trp)   
        {
            return objRe.ConsultaReporte(fecha1,fecha2,trp);
        }
    }
}
