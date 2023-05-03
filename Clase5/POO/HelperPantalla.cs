using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class HelperPantalla
    {

   
        internal void MostrarMensajeConSalto(string texto)
        {
            Console.WriteLine(texto);
        }

        internal void MostrarMensajeSinSalto(string texto)
        {
            Console.Write(texto);
        }
        internal string IngresarDato()
        {
            return Console.ReadLine();
        }

    }
}
