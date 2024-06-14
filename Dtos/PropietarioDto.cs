using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Dtos
{
    /// <summary>
    /// Clase que contiene los dtos de los propietarios
    /// irodhan -> 14/06/2024
    /// </summary>
    internal class PropietarioDto
    {
        //Atributos
        private long idPropietario;
        private string dniPropietario="aaaaa";
        private DateTime fchCompra=DateTime.Now;
        private string matriculaP = "aaaaa";
        private bool esHistorico=false;
        
        //Constructor
        public PropietarioDto(long idPropietario, string dniPropietario)
        {
            this.idPropietario = idPropietario;
            this.dniPropietario = dniPropietario;
        }

        public PropietarioDto(string dniPropietario, DateTime fchCompra, string matriculaP)
        {
            this.dniPropietario = dniPropietario;
            this.fchCompra = fchCompra;
            this.matriculaP = matriculaP;
        }

        //Getters & Setters
        public long IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string DniPropietario { get => dniPropietario; set => dniPropietario = value; }
        public DateTime FchCompra { get => fchCompra; set => fchCompra = value; }
        public string MatriculaP { get => matriculaP; set => matriculaP = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }

        //Metodo ToString
        override
        public string ToString()
        {
            string concatenacion = string.Concat("Nuevo propietario: ",this.idPropietario," - ",this.dniPropietario);
            return concatenacion;
        }
    }
}
