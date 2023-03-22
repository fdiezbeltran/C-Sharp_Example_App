using System;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda tienda1 = new Tienda("Ropa cool", "Cabildo 1543");
            Vendedor vendedor1 = new Vendedor("Juan", "Perez", 42353);
            vendedor1.AsignarTienda(tienda1);
            
            
            
            
            vendedor1.Cotizar(10, 100, 1);
            vendedor1.Cotizar(10, 100, 3);
            vendedor1.Cotizar(1, 300, 1);
            HistorialCotizaciones.MostrarHistorial();
            Console.ReadKey();
            
            
        }
    }
}
