using irodhan.Dtos;
using irodhan.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 14/06/2024
    /// </summary>
    internal class Program
    {
        //Variables
        public static string rutaFichero = "C:\\Users\\csi22-irodhan\\Desktop\\Programacion\\ExamenJunio\\irodhan\\Ficheros\\datosIniciales.txt";
        public static string rutaFicheroL = "C:\\Users\\csi22-irodhan\\Desktop\\Programacion\\ExamenJunio\\irodhan\\Logs\\";
        public static string rutaFicheroLog = string.Concat(rutaFicheroL,Utils.Utilidades.crearNombreLog());
        public static List<object> listaDatos;
        public static List<PropietarioDto> listaPropietarios=new List<PropietarioDto>();

        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 14/06/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        { 
            //Objetos
            MenuInterfaz mI =new MenuImplementacion();
            OperativaInterfaz oI = new OperativaImplementacion();
            FicheroInterfaz fI = new FicheroImplementacion();
            //Variables
            int opcion = 0;
            bool cerrarMenu=false;

            //Bucle do...while()
            do
            {
                try 
                {
                    opcion = mI.mostrarMenuYSeleccion();
                    switch ( opcion ) 
                    { 
                        case 0:
                            Console.WriteLine("[INFO] - Ha sido seleccionada la opcion 0 (Cerrar app)");
                            fI.escribirFicheroLog("[INFO] - Ha sido seleccionada la opcion 0 (Cerrar app)");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("[INFO] - Ha sido seleccionada la opcion 1 (Numero de vehiculos historicos)");
                            fI.escribirFicheroLog("[INFO] - Ha sido seleccionada la opcion 1 (Numero de vehiculos historicos)");
                            oI.numeroHistoricos();
                            break; 
                        case 2:
                            Console.WriteLine("[INFO] - Ha sido seleccionada la opcion 2 (Dar de alta a un nuevo propietario)");
                            fI.escribirFicheroLog("[INFO] - Ha sido seleccionada la opcion 2 (Dar de alta a un nuevo propietario");
                            oI.darAltaPropietario();
                            break;
                        default:
                            Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente.");
                            fI.escribirFicheroLog("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente.");
                            break;
                    }
                }
                catch (IOException e) 
                {
                    fI.escribirFicheroLog(e.Message);
                }
            } while (!cerrarMenu);
        }
    }
}
