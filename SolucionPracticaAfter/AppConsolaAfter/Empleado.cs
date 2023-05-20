using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsolaAfter
{
    internal class Empleado
    {
        public int NumeroEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        
        public List<Empleado> listaEmpleados { get; set; }


        public Empleado()
        {
            this.NumeroEmpleado = 0;
            this.Nombre = string.Empty;
            this.Telefono = string.Empty;
            this.Mail = string.Empty;
            listaEmpleados = new List<Empleado>();
        }

        public Empleado(int numeroEmpleado, string nombre, string telefono, string mail)
        {
            NumeroEmpleado = numeroEmpleado;
            Nombre = nombre;
            Telefono = telefono;
            Mail = mail;
            // carga primer empleado
            listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(this);
        }

        /// <summary>
        /// Carga un empleado a la lista
        /// </summary>
        /// <param name="empleado"></param>
        public void CargarEmpleado(Empleado empleado)
        {
            listaEmpleados.Add(empleado);
        }


    }
}
