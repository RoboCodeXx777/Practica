using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Models
{
    internal class Tipo_Documento
    {
        
        public string tipo { get; set; }

        public string getTipo()
        {
            return tipo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public Tipo_Documento(string tipo)
        {
            this.tipo = tipo;
        }

    }
}
