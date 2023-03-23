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

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }


        public Vendedor(string nom, string ape, int cod)
        {
            Nombre = nom;
            Apellido = ape;
            CodigoVendedor = cod;
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
                HistorialCotizaciones.AgregarCotizacion(cot);
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
    }
}
