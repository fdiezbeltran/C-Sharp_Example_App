using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Presentador
    {
        private readonly Vendedor vendedor1;
        private readonly IVista _vista;

        public Presentador(IVista vista)
        {
            _vista = vista;
        }

    }
}
