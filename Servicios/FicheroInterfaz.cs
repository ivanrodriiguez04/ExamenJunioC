using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Interfaz de los ficheros de la aplicacion
    /// irodhan -> 14/06/2024
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo que pasa la informacion del fichero a la lista correspondiente
        /// irodhan -> 14/06/2024
        /// </summary>
        public void cargaInicial();

        /// <summary>
        /// Metodo que escribe en el fichero log todo lo indicado
        /// irodhan -> 14/06/2024
        /// </summary>
        /// <param name="mensaje"></param>
        public void escribirFicheroLog(string mensaje);
    }
}
