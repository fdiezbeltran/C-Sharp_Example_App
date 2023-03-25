using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Cotizacion
    {
        private int numeroIdentificacion;
        private string fecha;
        private int codVendedor;
        private string prendaCotizada;
        private int cantidadCotizada;
        private float resultadoCotizacion;

        public int NumeroIdentificacion { get => numeroIdentificacion; }
        public string Fecha { get => fecha; }
        public int CodVendedor { get => codVendedor; }
        public string PrendaCotizada { get => prendaCotizada; }
        public int CantidadCotizada { get => cantidadCotizada; }
        public float ResultadoCotizacion { get => resultadoCotizacion; }

        static private int contadorID = 0;
        private string manga;
        private string cuello;
        private string corte;

        
        public Cotizacion(int cod, Prendas prenda, int cant)
        {
            contadorID = contadorID + 1;
            numeroIdentificacion = contadorID;
            DateTime localTime = DateTime.Now;
            fecha = localTime.ToString();
            codVendedor = cod;
            if(prenda is Camisas camisa)
            {
                manga = camisa.TipoDeManga;
                cuello = camisa.TipoDeCuello;
                prendaCotizada = "Camisa - " + manga + " - " + cuello + " - " + prenda.CalidadPrenda;
            }else if(prenda is Pantalones pantalon)
            {
                corte = pantalon.TipoDePantalon;
                prendaCotizada = "Pantalones - " + corte + " - " + prenda.CalidadPrenda;
            }
            cantidadCotizada = cant;                   
            CalculoCotizacion(prenda, manga, cuello, corte, CantidadCotizada);
        }

        public void CalculoCotizacion(Prendas _prenda, string manga, string cuello, string corte, int cant)
        {
            resultadoCotizacion = _prenda.PrecioUnitario;

            if(manga == "Manga corta")
            {
                resultadoCotizacion = _prenda.PrecioUnitario - _prenda.PrecioUnitario * 0.10f;
            }
            if(cuello == "Cuello mao")
            {
                resultadoCotizacion = _prenda.PrecioUnitario + _prenda.PrecioUnitario * 0.03f;
            }
            if (manga == "Manga corta" && cuello == "Cuello mao")
            {
                resultadoCotizacion = _prenda.PrecioUnitario - _prenda.PrecioUnitario * 0.10f;
                resultadoCotizacion = ResultadoCotizacion + ResultadoCotizacion * 0.03f;
            }
            if (corte == "Chupines")
            {
                resultadoCotizacion = _prenda.PrecioUnitario - _prenda.PrecioUnitario * 0.12f;
            }

            if(_prenda.CalidadPrenda == "Premium")
            {
                resultadoCotizacion = ResultadoCotizacion + ResultadoCotizacion * 0.3f;
            }
            
            resultadoCotizacion = ResultadoCotizacion * cant;
        }      
    }
}
