using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Dtos
{
    /// <summary>
    /// Clase que contiene los dtos de los vehiculos
    /// irodhan -> 14/06/2024
    /// </summary>
    internal class VehiculoDto
    {
        //Atributos
        private long idVehiculo;
        private string matriculaVehiculo = "aaaaa";
        private string fchMatriculacion = "aaaaa";

        //Constructores
        public VehiculoDto() 
        { }

        //Getters & Setters
        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string MatriculaVehiculo { get => matriculaVehiculo; set => matriculaVehiculo = value; }
        public string FchMatriculacion { get => fchMatriculacion; set => fchMatriculacion = value; }
        
    }
}
