using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Utils
{
    /// <summary>
    /// Clase que contiene todas las utilidades de la aplicacion
    /// irodhan -> 14/06/2024
    /// </summary>
    internal class Utilidades
    {
        /// <summary>
        /// Metodo que adquiere la fecha actual para crear el nombre del log de ese dia
        /// irodhan -> 14/06/2024
        /// </summary>
        /// <returns>Devuelve el nombre del fichero</returns>
        public static string crearNombreLog() 
        {
            string nombreFichero = "9";
            DateTime fchAtual= DateTime.Now;
            nombreFichero = string.Concat("log-", fchAtual.ToString("ddMMyyyy"), ".txt");
            return nombreFichero;

        }

        /// <summary>
        /// Metodo que asigna un id a un nuevo propietario
        /// irodhan -> 14/06/2024
        /// </summary>
        /// <returns></returns>
        public static long asignarId() 
        {
            long id;
            List<PropietarioDto> nuevaLista = Controladores.Program.listaPropietarios;
            int tamanyoLista=nuevaLista.Count;
            if (tamanyoLista> 0)
            {
                id = nuevaLista[tamanyoLista - 1].IdPropietario + 1;
            }
            else 
            {
                id = 1;
            }
            return id;
        }








        

    }
}
