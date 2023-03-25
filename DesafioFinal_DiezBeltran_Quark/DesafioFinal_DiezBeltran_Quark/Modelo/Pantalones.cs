using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Pantalones : Prendas
    {
        private string tipoDePantalon;

        public string TipoDePantalon { get => tipoDePantalon;}

        public Pantalones(int stock ,string tipo, string cal)
        {
            calidadPrenda = cal;
            this.stock = stock;
            tipoDePantalon = tipo;
        }
    }
}
