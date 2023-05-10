using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public static class HelperPantalla
    {

   
        internal static void MostrarMensajeConSalto(string texto)
        {
            Console.WriteLine(texto);
        }

        internal static void MostrarMensajeSinSalto(string texto)
        {
            Console.Write(texto);
        }
        internal static string IngresarDato()
        {
            return Console.ReadLine();
        }

    }
}
