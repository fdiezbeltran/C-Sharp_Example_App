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

        internal static List<Cotizacion> Cotizaciones { get => cotizaciones; set => cotizaciones = value; }

        
        public static void AgregarCotizacion(Cotizacion nuevaCotizacion)
        {
            cotizaciones.Add(nuevaCotizacion);
            
        }
        public static void MostrarHistorial()
        {
            foreach(Cotizacion cot in cotizaciones)
            {
                Console.WriteLine(" - - - - - - - HISTORIAL - - - - - - - ");
                Console.WriteLine(cot.NumeroIdentificacion);
                Console.WriteLine(cot.Fecha);
                Console.WriteLine(cot.CodVendedor);
                Console.WriteLine(cot.PrendaCotizada);
                Console.WriteLine(cot.CantidadCotizada);
                Console.WriteLine(cot.ResultadoCotizacion);
            }

        }
    }
}
