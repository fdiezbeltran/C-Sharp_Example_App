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
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        
        List<Prendas> listaDePrendas = new List<Prendas>();
        public Tienda(string nom, string dir)
        {
            Nombre = nom;
            Direccion = dir;
            Prendas prenda1 = new Camisas("Standard", 1, 100, "Manga corta", "Cuello mao");
            Prendas prenda2 = new Camisas("Premium", 1, 100, "Manga corta", "Cuello mao");
            Prendas prenda3 = new Camisas("Standard", 1, 150, "Manga corta", "Cuello comun");
            Prendas prenda4 = new Camisas("Premium", 1, 150, "Manga corta", "Cuello comun");
            Prendas prenda5 = new Camisas("Standard", 1, 75, "Manga larga", "Cuello mao");
            Prendas prenda6 = new Camisas("Premium", 1, 75, "Manga larga", "Cuello mao");
            Prendas prenda7 = new Camisas("Standard", 1, 175, "Manga larga", "Cuello comun");
            Prendas prenda8 = new Camisas("Premium", 1, 175, "Manga larga", "Cuello comun");
            Prendas prenda9 = new Pantalones("Standard", 1, 750, "Chupines");
            Prendas prenda10 = new Pantalones("Premium", 1, 750, "Chupines");
            Prendas prenda11 = new Pantalones("Standard", 1, 250, "Comunes");
            Prendas prenda12 = new Pantalones("Premium", 1, 250, "Comunes");

            listaDePrendas.Add(prenda1);
            listaDePrendas.Add(prenda2);
            listaDePrendas.Add(prenda3);
            listaDePrendas.Add(prenda4);
            listaDePrendas.Add(prenda5);
            listaDePrendas.Add(prenda6);
            listaDePrendas.Add(prenda7);
            listaDePrendas.Add(prenda8);
            listaDePrendas.Add(prenda9);
            listaDePrendas.Add(prenda10);
            listaDePrendas.Add(prenda11);
            listaDePrendas.Add(prenda12);

        }

    }
}
