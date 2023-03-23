using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal_DiezBeltran_Quark
{
    class VistaUsuario : IVista
    {
        private string codigoDePrenda;
        private int cantidadDePrendas;
        private float precioPorPrenda;
        
        private readonly Presentador presentador;

        public VistaUsuario()
        {
            presentador = new Presentador(this);
            MostrarMenuPrincipal();
        }
        string titulo = @",------.                            ,-----.              ,--.
|  .--. ' ,---.  ,---.  ,--,--.    '  .--./ ,---.  ,---. |  |
|  '--'.'| .-. || .-. |' ,-.  |    |  |    | .-. || .-. ||  |
|  |\  \ ' '-' '| '-' '\ '-'  |    '  '--'\' '-' '' '-' '|  |
`--' '--' `---' |  |-'  `--`--'     `-----' `---'  `---' `--'
                `--'
    ___ ___                                           ,==c==.
  /| |/|\| |\                                         |_/|\_|
 /_| ´ |.` |_\  Bienvenidos a la tienda Ropa Cool     | ´|` |
   |   |.  |                                          |  |  |
   |   |.  |  Los mejores precios, la mejor calidad.  |  |  |
   |___|.__|                                          |__|__|

─────────────────────────────────────────────────────────────";


        public void MostrarMenuPrincipal()
        {
            string opcionElegida;
            bool salir = false;


            do
            {
                Console.Clear();
                MostrarTexto(titulo);
                MostrarTexto("Elija una opcion:");
                MostrarTexto("1: Realizar una cotizacion.");
                MostrarTexto("2: Historial de cotizaciones.");
                MostrarTexto("X: Salir.");
                opcionElegida = Console.ReadLine();
                OpcionMenuPrincipal(opcionElegida, ref salir);
            } while (salir == false);
        }
        public void OpcionMenuPrincipal(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    MenuCotizacion();
                    salir = false;
                    break;
                case "2":
                    //metodo de mostrar historial
                    Console.ReadKey();
                    salir = false;
                    break;
                case "x":
                case "X":
                    Environment.Exit(2);
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    salir = false;
                    break;
            }
        }
        public void MenuCotizacion()
        {
            string opcionElegida;
            bool salir = false;

            do
            {
                Console.Clear();
                MostrarTexto(titulo);
                MostrarTexto("Pulse X para salir o H para consultar el historial de cotizaciones.");
                MostrarTexto("-------------------------------------------------------------------");
                MostrarTexto("Desea cotizar Camisas(1) o Pantalones(2)?");
                opcionElegida = Console.ReadLine();
                OpcionPrenda(opcionElegida, ref salir);
                if (opcionElegida == "1")
                {
                    MostrarTexto("Manga corta(1) o Manga larga(2)?");
                    opcionElegida = Console.ReadLine();
                    OpcionManga(opcionElegida, ref salir);
                    MostrarTexto("Cuello mao(1) o Cuello comun(2)?");
                    opcionElegida = Console.ReadLine();
                    OpcionCuello(opcionElegida, ref salir);
                    MostrarTexto("Calidad Stardard(1) o Premium(2)?");
                    opcionElegida = Console.ReadLine();
                    OpcionCalidad(opcionElegida, ref salir);
                }
                else if (opcionElegida == "2")
                {
                    MostrarTexto("Comunes(1) o Chupines(2)?");
                    opcionElegida = Console.ReadLine();
                    OpcionCorte(opcionElegida, ref salir);
                    MostrarTexto("Calidad Stardard(1) o Premium(2)?");
                    opcionElegida = Console.ReadLine();
                    OpcionCalidad(opcionElegida, ref salir);
                }
                MostrarTexto("Que cantidad de prendas desea cotizar?");
                cantidadDePrendas = int.Parse(Console.ReadLine());
                MostrarTexto("Cual es el precio unitario de la prenda?");
                precioPorPrenda = float.Parse(Console.ReadLine());
                presentador.PedirCotizacion();


            } while (salir == false);
        }
        public void OpcionPrenda(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop--;
                    Console.WriteLine("Camisas");
                    codigoDePrenda = "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop--;
                    Console.WriteLine("Pantalones");
                    codigoDePrenda = "10";
                    salir = false;
                    break;
                case "x":
                case "X":
                    MostrarMenuPrincipal();
                    break;
                case "h":
                case "H":
                    //historial de cotizaciones
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    salir = false;
                    break;
            }
        }
        public void OpcionManga(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop--;
                    Console.WriteLine("Manga corta");
                    codigoDePrenda = codigoDePrenda + "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop--;
                    Console.WriteLine("Manga larga");
                    codigoDePrenda = codigoDePrenda + "1";
                    salir = false;
                    break;
                case "x":
                case "X":
                    MostrarMenuPrincipal();
                    break;
                case "h":
                case "H":
                    //historial de cotizaciones
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    salir = false;
                    break;
            }
        }
        public void OpcionCuello(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop--;
                    Console.WriteLine("Cuello mao");
                    codigoDePrenda = codigoDePrenda + "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop--;
                    Console.WriteLine("Cuello comun");
                    codigoDePrenda = codigoDePrenda + "1";
                    salir = false;
                    break;
                case "x":
                case "X":
                    MostrarMenuPrincipal();
                    break;
                case "h":
                case "H":
                    //historial de cotizaciones
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    salir = false;
                    break;
            }
        }
        public void OpcionCorte(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop--;
                    Console.WriteLine("Comunes");
                    codigoDePrenda = codigoDePrenda + "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop--;
                    Console.WriteLine("Chupines");
                    codigoDePrenda = codigoDePrenda + "1";
                    salir = false;
                    break;
                case "x":
                case "X":
                    MostrarMenuPrincipal();
                    break;
                case "h":
                case "H":
                    //historial de cotizaciones
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    salir = false;
                    break;
            }
        }
        public void OpcionCalidad(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop--;
                    Console.WriteLine("Standard");
                    codigoDePrenda = codigoDePrenda + "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop--;
                    Console.WriteLine("Premium");
                    codigoDePrenda = codigoDePrenda + "1";
                    salir = false;
                    break;
                case "x":
                case "X":
                    MostrarMenuPrincipal();
                    break;
                case "h":
                case "H":
                    //historial de cotizaciones
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    salir = false;
                    break;
            }
        }



        //Metodos de la interfaz
        public void MostrarTexto(string texto)
        {
            Console.WriteLine(texto);
        }
        public int MostrarCodigoDePrenda()
        {
            return int.Parse(codigoDePrenda);
        }
        public float MostrarPrecioPorPrenda()
        {
            return precioPorPrenda;
        }
        public int MostrarCantidadDePrendas()
        {
            return cantidadDePrendas;
        }
    }
}

