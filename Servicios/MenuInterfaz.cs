using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Interfaz de los menus de la aplicacion
    /// irodhan -> 14/06/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal de la aplicacion
        /// irodhan -> 14/06/2024
        /// </summary>
        /// <returns>Devuelve la opcion indicada por el usuario</returns>
        public int mostrarMenuYSeleccion();
    }
}
