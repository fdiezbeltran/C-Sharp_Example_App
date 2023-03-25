using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigoVendedor;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int CodigoVendedor { get => codigoVendedor; }


        public Vendedor(string nom, string ape, int cod)
        {
            nombre = nom;
            apellido = ape;
            codigoVendedor = cod;
        }

        private Tienda tienda;
        private Prendas prendaElegida;        
        
        public void AsignarTienda(Tienda tienda)
        {
            this.tienda = tienda;
        }
        public Cotizacion Cotizar(int codigoPrenda, float precioUnitario, int cant)
        {
            ElegirPrenda(codigoPrenda);
            if(prendaElegida.Stock >= cant)
            {
                prendaElegida.PrecioUnitario = precioUnitario;
                Cotizacion cot = new Cotizacion(CodigoVendedor, prendaElegida, cant);
                EnviarCotizacionHistorial(cot);
                return cot;
            }
            else
            {
                return null;
            }

        }
        public void ElegirPrenda(int codigoPrenda)
        {
            prendaElegida = tienda.ListadoDePrendas[codigoPrenda];
        }
        public void EnviarCotizacionHistorial(Cotizacion cotizacion)
        {
            HistorialCotizaciones.AgregarCotizacion(cotizacion);
        }
    }
}
