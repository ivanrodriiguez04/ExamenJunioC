using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los menus
    /// irodhan -> 14/06/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|               Menu               |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("| 0. Cerrar aplicacion             |");
            Console.WriteLine("| 1. Números  de coches historicos |");
            Console.WriteLine("| 2. Dar alta un nuevo propietario |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("Introduce que opcion desea utilizar: ");
            opcion=Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
