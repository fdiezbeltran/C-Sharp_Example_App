using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    public interface IVista
    {
        void MostrarTexto(string texto);

        int MostrarCodigoDePrenda();
        float MostrarPrecioPorPrenda();
        int MostrarCantidadDePrendas();

        void MostrarTitulo();
    }

    
}
