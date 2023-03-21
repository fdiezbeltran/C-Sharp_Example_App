using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Pantalones : Prendas
    {
        string tipoDePantalon;

        public string TipoDePantalon { get => tipoDePantalon;}

        public Pantalones(string cal, int precio, int stock ,string tipo)
        {
            calidadPrenda = cal;
            precioUnitario = precio;
            this.stock = stock;
            tipoDePantalon = tipo;
        }
    }
}
