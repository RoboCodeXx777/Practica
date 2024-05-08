using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Models
{
    internal class Puesto
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public Puesto (string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }


    }
}
