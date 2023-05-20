using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsolaAfter
{
    static internal class Helper
    {
        
        
        
        static public void CargarLista(ref Empleado pEmpleado)
        {
            for (int i = 0; i < 2; i++)
            {
                Empleado empleado = new Empleado();
                empleado.NumeroEmpleado = i + 1;
                Console.WriteLine("Ingrese Nombre del Empleado.");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Telefono del Empleado.");
                empleado.Telefono = Console.ReadLine();
                Console.WriteLine("Ingrese Mail del Empleado.");
                empleado.Mail = Console.ReadLine();

                pEmpleado.listaEmpleados.Add(empleado);
            }
        }
        
        
        
        
        static public List<Empleado> CargarLista()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            for (int i = 0; i < 5; i++)
            {
                // una clase en C# es un tipo C# es fuertemente tipado
                // variable: tipo Nombre
                Empleado empleado = new Empleado();
                // asignarle al numero de emplado la posicion + 1 para que tome los valores del 1 al 5 simulo
                // id auto numerico
                empleado.NumeroEmpleado = i + 1;
                Console.WriteLine("Ingrese Nombre del Empleado.");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Telefono del Empleado.");
                empleado.Telefono = Console.ReadLine();
                Console.WriteLine("Ingrese Mail del Empleado.");
                empleado.Mail = Console.ReadLine();

                listaEmpleados.Add(empleado);
            }
            return listaEmpleados;
        }


        static public void CargaryMostrarLista()
        {
            List<Empleado> lista = Helper.CargarLista();
            MostrarLista(lista);
        }

        static public void MostrarLista(List<Empleado> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine("Numero Empleado: " + item.NumeroEmpleado.ToString());
                Console.WriteLine("Nombre: " + item.Mail);
                Console.WriteLine("Telefono: " + item.Telefono);
                Console.WriteLine("Mail: " + item.Mail);
            }

        }


    }
}
