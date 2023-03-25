using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Camisas : Prendas
    {
        private string tipoDeManga;
        private string tipoDeCuello;
        public string TipoDeManga { get => tipoDeManga;}
        public string TipoDeCuello { get => tipoDeCuello;}

        public Camisas(int stock, string manga, string cuello, string cal)
        {
            calidadPrenda = cal;
            this.stock = stock;
            tipoDeManga = manga;
            tipoDeCuello = cuello;
        }
    }
}
