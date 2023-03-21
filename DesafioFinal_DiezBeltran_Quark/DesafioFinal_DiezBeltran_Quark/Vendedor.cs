using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigoVendedor;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }

        public Vendedor(string nom, string ape, int cod)
        {
            Nombre = nom;
            Apellido = ape;
            CodigoVendedor = cod;
        }
        public void Cotizar(string prenda, int cant)
        {
            Cotizacion cot1 = new Cotizacion(CodigoVendedor, prenda, cant);
        }
    }
}
