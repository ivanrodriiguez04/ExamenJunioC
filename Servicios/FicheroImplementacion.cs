using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los ficheros
    /// irodhan -> 14/06/2024
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void cargaInicial()
        {
            try
            {
                string[] lineas = File.ReadAllLines(Controladores.Program.rutaFichero);
                foreach (string linea in lineas)
                {
                    VehiculoDto vehiculo = new VehiculoDto(); 

                    string[] campos = linea.Split(";");
                    vehiculo.MatriculaVehiculo = campos[0];
                    string matriculaP = campos[0];
                    vehiculo.FchMatriculacion = campos[1];
                    string dniPropietario = campos[2];
                    DateTime fchCompra= Convert.ToDateTime(campos[3]);
                    PropietarioDto propietario = new PropietarioDto(dniPropietario, fchCompra,matriculaP) ;
                    Controladores.Program.listaDatos.Add(vehiculo);
                    Controladores.Program.listaDatos.Add(propietario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void escribirFicheroLog(string mensaje)
        {
            StreamWriter sw = null;
            try
            {
                using (sw = new StreamWriter(Controladores.Program.rutaFicheroLog))
                {
                    sw.WriteLine(mensaje);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }

            }
        }
    }
}
