using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Models
{
    internal class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string numeroDocumento { get; set; }
        public Tipo_Documento tipoDocumento { get; set; }
        public Puesto puesto { get; set; }

        public string getNombre()
        { 
            return nombre; 
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public void setApellido (string apellido)
        {
            this.apellido = apellido;
        }
        public DateTime getFechaNacimiento()
        {
            return fechaNacimiento; 
        }

    }
}
