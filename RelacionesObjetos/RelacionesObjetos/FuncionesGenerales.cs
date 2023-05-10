using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionesObjetos
{
    public static class FuncionesGenerales
    {
        public static void MostrarMensaje(string texto)
        {
            Console.WriteLine(texto);
        }

        public static string IngresarValor()
        {
            return Console.ReadLine();
        }

    }
}
