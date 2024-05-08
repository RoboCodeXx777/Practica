using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Models
{
    internal class Administradora
    {
        public Empleado listaEmpleado { get; set; }
        public Puesto listaPuesto { get; set; }
        public Tipo_Documento listaTipo_Documento { get; set; }
        public List<Empleado> empleados;
        public void agregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }
    }
}
