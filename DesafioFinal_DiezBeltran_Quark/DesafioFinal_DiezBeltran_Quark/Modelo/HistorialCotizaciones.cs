using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    static class HistorialCotizaciones
    {
        private static List<Cotizacion> cotizaciones = new List<Cotizacion>();

        internal static List<Cotizacion> Cotizaciones { get => cotizaciones; }    
        
        public static void AgregarCotizacion(Cotizacion nuevaCotizacion)
        {
            cotizaciones.Add(nuevaCotizacion);
            
        }        
    }
}
