using System;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor1 = new Vendedor("Juan", "Perez", 42353);
            vendedor1.Cotizar("remera manga larga", 5);
            vendedor1.Cotizar("remera manga corta", 3);
            vendedor1.Cotizar("pantalon chupin", 7);
            Console.ReadKey();
            
            
        }
    }
}
