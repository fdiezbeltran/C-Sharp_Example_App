using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Presentador
    {
        private Tienda _tienda;
        private Vendedor vendedor1;
        private Cotizacion cot;
        private readonly IVista _vista;

        public Presentador(IVista vista, string nombre, string apellido, int codigo)
        {
            _vista = vista;
            _tienda = new Tienda("Ropa Cool", "Cabildo 1543");
            vendedor1 = new Vendedor(nombre, apellido, codigo);
            vendedor1.AsignarTienda(_tienda);
        }

        public void MostrarDatosTienda()
        {
            _vista.MostrarTexto(_tienda.Nombre + "                                               " + _tienda.Direccion);
        }
        public void MostrarDatosVendedor()
        {
            _vista.MostrarTexto(vendedor1.Nombre + " " + vendedor1.Apellido + " - Codigo: " + vendedor1.CodigoVendedor);
        }


        public void PedirCotizacion()
        {
            cot = vendedor1.Cotizar(_vista.MostrarCodigoDePrenda(), _vista.MostrarPrecioPorPrenda(), _vista.MostrarCantidadDePrendas());
            if(cot != null)
            {
                _vista.MostrarTitulo();
                ImprimirCotizacion();
            }
            else
            {
                _vista.MostrarTitulo();
                FaltaDeStock();
            }
        }

        public void ImprimirCotizacion()
        {
            
            _vista.MostrarTexto("ID de la cotizacion: " + cot.NumeroIdentificacion);
            _vista.MostrarTexto(cot.Fecha);
            _vista.MostrarTexto("Codigo de vendedor: " + cot.CodVendedor);
            _vista.MostrarTexto("Prenda cotizada: " + cot.PrendaCotizada);
            _vista.MostrarTexto("Cantidad de prendas a cotizar: " + cot.CantidadCotizada);
            _vista.MostrarTexto("Precio final de la cotizacion: $" + cot.ResultadoCotizacion);
            _vista.MostrarTexto("-------------------------------------------------------------------");
            _vista.MostrarTexto("Presione una tecla para cerrar la cotizacion.");

        }

        public void FaltaDeStock()
        {
            _vista.MostrarTexto("Stock insuficiente del producto elegido.");
            _vista.MostrarTexto("-------------------------------------------------------------------");
            _vista.MostrarTexto("Presione una tecla para volver al menu incial.");
        }

        public void ImprimirHistorial()
        {            
            _vista.MostrarTexto(" - - - - - - - - - - - - - - HISTORIAL - - - - - - - - - - - - - - -");
            foreach (Cotizacion cot in HistorialCotizaciones.Cotizaciones)
            {
                _vista.MostrarTexto("ID de la cotizacion: " + cot.NumeroIdentificacion);
                _vista.MostrarTexto(cot.Fecha);
                _vista.MostrarTexto("Codigo de vendedor: " + cot.CodVendedor);
                _vista.MostrarTexto("Prenda cotizada: " + cot.PrendaCotizada);
                _vista.MostrarTexto("Cantidad de prendas a cotizar: " + cot.CantidadCotizada);
                _vista.MostrarTexto("Precio final de la cotizacion: $" + cot.ResultadoCotizacion);
                _vista.MostrarTexto("-------------------------------------------------------------------");
            }            
            if(HistorialCotizaciones.Cotizaciones.Count == 0)
            {
                _vista.MostrarTexto("Todavia no hay ninguna cotizacion guardada en el historial.");
                _vista.MostrarTexto("-------------------------------------------------------------------");
            }
        }
    }
}
