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

        private Presentador presentador;

        

        public VistaUsuario()
        {
            MostrarLogin();            
        }
        string titulo = @"    ,------.                           ,-----.              ,--.
    |  .--. ' ,---.  ,---.  ,--,--.   '  .--./ ,---.  ,---. |  |
    |  '--'.'| .-. || .-. |' ,-.  |   |  |    | .-. || .-. ||  |
    |  |\  \ ' '-' '| '-' '\ '-'  |   '  '--'\' '-' '' '-' '|  |
    `--' '--' `---' |  |-'  `--`--'    `-----' `---'  `---' `--'
                    `--'
    ___ ___                                                ,==c==.
  /| |/|\| |\                                              |_/|\_|
 /_| ´ |.` |_\     Bienvenidos a la tienda Ropa Cool       | ´|` |
   |   |.  |                                               |  |  |
   |   |.  |     Los mejores precios, la mejor calidad.    |  |  |
   |___|.__|                                               |__|__|

────────────────────────────────────────────────────────────────────";


        public void MostrarLogin()
        {
            Console.Clear();
            MostrarTexto(titulo);
            Console.CursorLeft = 20;
            MostrarTexto("Ingrese nombre del usuario.");
            Console.CursorLeft = 30;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            string nombre = Console.ReadLine();
            Console.CursorLeft = 20;
            Console.BackgroundColor = ConsoleColor.Black;
            MostrarTexto("Ingrese apellido del usuario.");
            Console.CursorLeft = 30;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            string apellido = Console.ReadLine();
            Console.CursorLeft = 20;
            Console.BackgroundColor = ConsoleColor.Black;
            MostrarTexto("Ingrese el codigo de vendedor.");
            Console.CursorLeft = 30;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            int codigo = 0;
            try
            {
                codigo = int.Parse(Console.ReadLine());          
            }
            catch (FormatException e)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                MostrarTexto("Pulse cualquier tecla para continuar.");
                Console.ReadKey();
                MostrarLogin();
            }
            presentador = new Presentador(this, nombre, apellido, codigo);
            Console.BackgroundColor = ConsoleColor.Black;
            MostrarMenuPrincipal();
        }
        public void MostrarMenuPrincipal()
        {
            string opcionElegida;
            bool salir = false;
            do
            {
                MostrarTitulo();
                MostrarTexto("Elija una opcion:");
                Console.WriteLine();
                Console.CursorLeft = 5;
                MostrarTexto("1: Realizar una cotizacion.");
                Console.WriteLine();
                Console.CursorLeft = 5;
                MostrarTexto("2: Cambiar de usuario.");
                Console.WriteLine();
                Console.CursorLeft = 5;
                MostrarTexto("H : Historial de cotizaciones.");
                Console.WriteLine();
                Console.CursorLeft = 5;
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
                    MostrarLogin();
                    salir = false;
                    break;
                case "h":
                case "H":
                    MostrarHistorial();
                    salir = false;
                    break;
                case "x":
                case "X":
                    Environment.Exit(2);
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    MostrarTexto("Pulse cualquier tecla para continuar.");
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
                MostrarTitulo();
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
                ValidarCantidad();
                MostrarTexto("Cual es el precio unitario de la prenda?");
                ValidarPrecio();
                MostrarTexto("Desea confirmar la cotizacion? Confirmar(1) - Cancelar(2)");
                opcionElegida = Console.ReadLine();
                OpcionConfirmar(opcionElegida, ref salir);
                Console.ReadKey();
                MostrarMenuPrincipal();


            } while (salir == false);
        }
        public void OpcionPrenda(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
                    Console.WriteLine("Camisas");
                    codigoDePrenda = "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
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
                    MostrarHistorial();
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    MostrarTexto("Pulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuCotizacion();
                    salir = false;
                    break;
            }
        }
        public void OpcionManga(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
                    Console.WriteLine("Manga corta");
                    codigoDePrenda = codigoDePrenda + "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
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
                    MostrarHistorial();
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    MostrarTexto("Pulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuCotizacion();
                    salir = false;
                    break;
            }
        }
        public void OpcionCuello(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
                    Console.WriteLine("Cuello mao");
                    codigoDePrenda = codigoDePrenda + "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
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
                    MostrarHistorial();
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    MostrarTexto("Pulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuCotizacion();
                    salir = false;
                    break;
            }
        }
        public void OpcionCorte(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
                    Console.WriteLine("Comunes");
                    codigoDePrenda = codigoDePrenda + "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
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
                    MostrarHistorial();
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    MostrarTexto("Pulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuCotizacion();
                    salir = false;
                    break;
            }
        }
        public void OpcionCalidad(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
                    Console.WriteLine("Standard");
                    codigoDePrenda = codigoDePrenda + "0";
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
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
                    MostrarHistorial();
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    MostrarTexto("Pulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuCotizacion();
                    salir = false;
                    break;
            }
        }
        public void OpcionConfirmar(string opcionElegida, ref bool salir)
        {
            switch (opcionElegida)
            {
                case "1":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
                    presentador.PedirCotizacion();
                    salir = false;
                    break;
                case "2":
                    Console.CursorTop = Console.CursorTop - 2;
                    Console.Write("                                                            ");
                    Console.CursorLeft = 0;
                    MenuCotizacion();
                    salir = false;
                    break;
                case "x":
                case "X":
                    MostrarMenuPrincipal();
                    break;
                case "h":
                case "H":
                    MostrarHistorial();
                    break;
                default:
                    MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                    MostrarTexto("Pulse cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuCotizacion();
                    salir = false;
                    break;
            }
        }
        public void ValidarCantidad()
        {            
            try
            {
                string linea = Console.ReadLine();
                if(linea == "h" || linea == "H")
                {
                    MostrarHistorial();
                }
                if (linea == "x" || linea == "X")
                {
                    MostrarMenuPrincipal();
                }
                cantidadDePrendas = int.Parse(linea);
            }
            catch(FormatException e)
            {
                MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                MostrarTexto("Pulse cualquier tecla para continuar.");
                Console.ReadKey();
                MenuCotizacion();
            }
        }
        public void ValidarPrecio()
        {
            try
            {
                string linea = Console.ReadLine();
                if (linea == "h" || linea == "H")
                {
                    MostrarHistorial();
                }
                if (linea == "x" || linea == "X")
                {
                    MostrarMenuPrincipal();
                }
                precioPorPrenda = float.Parse(linea);
            }
            catch (FormatException e)
            {
                MostrarTexto("La opción ingresada es inválida, por favor reintente.");
                MostrarTexto("Pulse cualquier tecla para continuar.");
                Console.ReadKey();
                MenuCotizacion();
            }
        }

        public void MostrarHistorial()
        {
            Console.Clear();
            presentador.ImprimirHistorial();
            MostrarTexto("Presione cualquier tecla para cerrar el historial.");
            Console.ReadKey();
            MostrarMenuPrincipal();
        }


        //Metodos de la interfaz
        public void MostrarTitulo()
        {
            Console.Clear();
            MostrarTexto(titulo);
            presentador.MostrarDatosTienda();
            presentador.MostrarDatosVendedor();
            MostrarTexto("────────────────────────────────────────────────────────────────────");
        }
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

