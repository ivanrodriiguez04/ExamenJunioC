using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de la aplicacion
    /// irodhan -> 14/06/2024
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaPropietario()
        {
            PropietarioDto propietario = crearPropietario();
            Controladores.Program.listaPropietarios.Add(propietario);
        }

        public void numerosHistoricos()
        {
            VehiculoDto vehiculo = new VehiculoDto();
            PropietarioDto propietario;
        }

        /// <summary>
        /// Metodo que asigna el id al nuevo propietario y comprueba la longitud del dni
        /// irodhan -> 14/06/2024
        /// </summary>
        /// <returns>Devuelve un nuevo propietario</returns>
        private PropietarioDto crearPropietario() 
        {
            //Variables
            bool aux=false;
            string dni;
            int comprobacion = 0;
            long id;
            Console.WriteLine("Introduce tu dni: ");
            dni = Console.ReadLine(); 
            comprobacion = dni.Length;
            if (comprobacion == 9) 
            {
               id = Utils.Utilidades.asignarId();
            }
            PropietarioDto  p =new PropietarioDto(id,dni);

            Console.WriteLine(p.ToString());
            return p;
        }

    }
}
