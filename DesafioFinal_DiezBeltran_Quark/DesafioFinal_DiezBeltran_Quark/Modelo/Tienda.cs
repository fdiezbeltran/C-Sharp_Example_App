using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prendas> listaDePrendas = new List<Prendas>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Prendas> ListaDePrendas { get => listaDePrendas; }

        public Tienda(string nom, string dir)
        {
            Nombre = nom;
            Direccion = dir;
            Prendas prenda1 = new Camisas(100, "Manga corta", "Cuello mao", "Standard");
            Prendas prenda2 = new Camisas(100, "Manga corta", "Cuello mao", "Premium");
            Prendas prenda3 = new Camisas(150, "Manga corta", "Cuello comun", "Standard");
            Prendas prenda4 = new Camisas(150, "Manga corta", "Cuello comun", "Premium");
            Prendas prenda5 = new Camisas(75, "Manga larga", "Cuello mao", "Standard");
            Prendas prenda6 = new Camisas(75, "Manga larga", "Cuello mao", "Premium");
            Prendas prenda7 = new Camisas(175, "Manga larga", "Cuello comun", "Standard");
            Prendas prenda8 = new Camisas(175, "Manga larga", "Cuello comun", "Premium");
            Prendas prenda9 = new Pantalones(750, "Chupines", "Standard");
            Prendas prenda10 = new Pantalones(750, "Chupines", "Premium");
            Prendas prenda11 = new Pantalones(250, "Comunes", "Standard");
            Prendas prenda12 = new Pantalones(250, "Comunes", "Premium");

            ListaDePrendas.Add(prenda1);
            ListaDePrendas.Add(prenda2);
            ListaDePrendas.Add(prenda3);
            ListaDePrendas.Add(prenda4);
            ListaDePrendas.Add(prenda5);
            ListaDePrendas.Add(prenda6);
            ListaDePrendas.Add(prenda7);
            ListaDePrendas.Add(prenda8);
            ListaDePrendas.Add(prenda9);
            ListaDePrendas.Add(prenda10);
            ListaDePrendas.Add(prenda11);
            ListaDePrendas.Add(prenda12);

        }

    }
}
