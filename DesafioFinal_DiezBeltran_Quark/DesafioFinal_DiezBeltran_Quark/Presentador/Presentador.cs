using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Presentador
    {
        private Vendedor vendedor1;
        private Cotizacion cot;
        private readonly IVista _vista;

        public Presentador(IVista vista)
        {
            _vista = vista;
        }
        
        public void PedirCotizacion()
        {
            cot = vendedor1.Cotizar(_vista.MostrarCodigoDePrenda(), _vista.MostrarPrecioPorPrenda(), _vista.MostrarCantidadDePrendas());
            ImprimirCotizacion();
        }

        public void ImprimirCotizacion()
        {
            Console.Clear();
            _vista.MostrarTexto("ID de la cotizacion: " + cot.NumeroIdentificacion);
            _vista.MostrarTexto(cot.Fecha);
            _vista.MostrarTexto("Codigo de vendedor: " + cot.CodVendedor);
            _vista.MostrarTexto("Prenda cotizada: " + cot.PrendaCotizada);
            _vista.MostrarTexto("Cantidad de prendas a cotizar: " + cot.CantidadCotizada);
            _vista.MostrarTexto("Precio final de la cotizacion: $" + cot.ResultadoCotizacion);

        }
    }
}
