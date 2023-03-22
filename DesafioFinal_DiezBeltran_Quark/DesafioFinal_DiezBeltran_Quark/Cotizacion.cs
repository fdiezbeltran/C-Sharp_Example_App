using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Cotizacion
    {
        static int numeroIdentificacion = 0;
        private string fecha;
        private int codVendedor;
        private string prendaCotizada;
        private int cantidadCotizada;
        private float resultadoCotizacion;

        public int NumeroIdentificacion { get => numeroIdentificacion; set => numeroIdentificacion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int CodVendedor { get => codVendedor; set => codVendedor = value; }
        public string PrendaCotizada { get => prendaCotizada; set => prendaCotizada = value; }
        public int CantidadCotizada { get => cantidadCotizada; set => cantidadCotizada = value; }
        public float ResultadoCotizacion { get => resultadoCotizacion; set => resultadoCotizacion = value; }

        
        private string manga;
        private string cuello;
        private string corte;

        
        public Cotizacion(int cod, Prendas prenda, int cant)
        {
            NumeroIdentificacion = NumeroIdentificacion + 1;
            DateTime localTime = DateTime.Now;
            Fecha = localTime.ToString();
            CodVendedor = cod;
            if(prenda is Camisas camisa)
            {
                manga = camisa.TipoDeManga;
                cuello = camisa.TipoDeCuello;
                PrendaCotizada = "Camisa - " + manga + " - " + cuello + " - " + prenda.CalidadPrenda;
            }else if(prenda is Pantalones pantalon)
            {
                corte = pantalon.TipoDePantalon;
                PrendaCotizada = "Pantalones - " + corte + " - " + prenda.CalidadPrenda;
            }
            CantidadCotizada = cant;


            
            CalculoCotizacion(prenda, manga, cuello, corte, CantidadCotizada);

            

            Console.WriteLine(NumeroIdentificacion);
            Console.WriteLine(Fecha);
            Console.WriteLine(CodVendedor);
            Console.WriteLine(PrendaCotizada);
            Console.WriteLine(CantidadCotizada);
            Console.WriteLine(ResultadoCotizacion);
            Console.WriteLine("------------------------------");
            
            


        }

        public void CalculoCotizacion(Prendas _prenda, string manga, string cuello, string corte, int cant)
        {
            ResultadoCotizacion = _prenda.PrecioUnitario;

            if(manga == "Manga corta")
            {
                ResultadoCotizacion = _prenda.PrecioUnitario - _prenda.PrecioUnitario * 0.10f;
            }
            if(cuello == "Cuello mao")
            {
                ResultadoCotizacion = _prenda.PrecioUnitario + _prenda.PrecioUnitario * 0.03f;
            }
            if (manga == "Manga corta" && cuello == "Cuello mao")
            {
                ResultadoCotizacion = _prenda.PrecioUnitario - _prenda.PrecioUnitario * 0.10f;
                ResultadoCotizacion = ResultadoCotizacion + ResultadoCotizacion * 0.03f;
            }
            if (corte == "Chupines")
            {
                ResultadoCotizacion = _prenda.PrecioUnitario - _prenda.PrecioUnitario * 0.12f;
            }

            if(_prenda.CalidadPrenda == "Premium")
            {
                ResultadoCotizacion = ResultadoCotizacion + ResultadoCotizacion * 0.3f;
            }
            
            ResultadoCotizacion = ResultadoCotizacion * cant;
        }
      
    }
}
