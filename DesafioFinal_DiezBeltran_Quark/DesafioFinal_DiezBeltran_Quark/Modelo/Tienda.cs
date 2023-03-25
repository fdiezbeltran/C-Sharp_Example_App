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
        private Dictionary<int, Prendas> listadoDePrendas = new Dictionary<int, Prendas>();

        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }
        internal Dictionary<int, Prendas> ListadoDePrendas { get => listadoDePrendas; }
                
        public Tienda(string nom, string dir)
        {
            nombre = nom;
            direccion = dir;
            Prendas prenda1 = new Camisas(100, "Manga corta", "Cuello mao", "Standard");
            Prendas prenda2 = new Camisas(100, "Manga corta", "Cuello mao", "Premium");
            Prendas prenda3 = new Camisas(150, "Manga corta", "Cuello comun", "Standard");
            Prendas prenda4 = new Camisas(150, "Manga corta", "Cuello comun", "Premium");
            Prendas prenda5 = new Camisas(75, "Manga larga", "Cuello mao", "Standard");
            Prendas prenda6 = new Camisas(75, "Manga larga", "Cuello mao", "Premium");
            Prendas prenda7 = new Camisas(175, "Manga larga", "Cuello comun", "Standard");
            Prendas prenda8 = new Camisas(175, "Manga larga", "Cuello comun", "Premium");
            Prendas prenda9 = new Pantalones(250, "Comunes", "Standard");
            Prendas prenda10 = new Pantalones(250, "Comunes", "Premium");
            Prendas prenda11 = new Pantalones(750, "Chupines", "Standard");
            Prendas prenda12 = new Pantalones(750, "Chupines", "Premium");

            ListadoDePrendas.Add(0000, prenda1);
            ListadoDePrendas.Add(0001, prenda2);
            ListadoDePrendas.Add(0010, prenda3);
            ListadoDePrendas.Add(0011, prenda4);
            ListadoDePrendas.Add(0100, prenda5);
            ListadoDePrendas.Add(0101, prenda6);
            ListadoDePrendas.Add(0110, prenda7);
            ListadoDePrendas.Add(0111, prenda8);
            ListadoDePrendas.Add(1000, prenda9);
            ListadoDePrendas.Add(1001, prenda10);
            ListadoDePrendas.Add(1010, prenda11);
            ListadoDePrendas.Add(1011, prenda12);
        }

    }
}
