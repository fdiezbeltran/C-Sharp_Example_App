using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Cotizacion
    {
        static int numeroIdentificacion = 00;
        private string fecha;
        private int codVendedor;
        private string prendaCotizada;
        private int cantidadCotizada;
        private int resultadoCotizacion;

        public int NumeroIdentificacion { get => numeroIdentificacion; set => numeroIdentificacion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int CodVendedor { get => codVendedor; set => codVendedor = value; }
        public string PrendaCotizada { get => prendaCotizada; set => prendaCotizada = value; }
        public int CantidadCotizada { get => cantidadCotizada; set => cantidadCotizada = value; }
        public int ResultadoCotizacion { get => resultadoCotizacion; set => resultadoCotizacion = value; }




        public Cotizacion(int cod, string prenda, int cant)
        {
            NumeroIdentificacion = NumeroIdentificacion + 1;
            DateTime localTime = DateTime.Now;
            Fecha = localTime.ToString();
            CodVendedor = cod;
            PrendaCotizada = prenda;
            CantidadCotizada = cant;
            mostrar();
        }

        public void mostrar()
        {
            Console.WriteLine(NumeroIdentificacion);
            Console.WriteLine(Fecha);
            Console.WriteLine(CodVendedor);
            Console.WriteLine(PrendaCotizada);
            Console.WriteLine(CantidadCotizada);
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
