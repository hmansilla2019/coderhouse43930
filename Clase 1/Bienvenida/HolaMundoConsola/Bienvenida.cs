using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoConsola
{
    internal class Bienvenida
    {
    

        public void DarBienvenida()
        {
            Console.WriteLine("Bienvenidos a CoderHouse!");

            string sNombre;
            int iEdad;
            int iCont = 0;

            while (iCont < 3)
            {
                Console.WriteLine("Ingrese su nombre:");
                sNombre = Console.ReadLine();

                Console.WriteLine("Ingrese su edad:");
                iEdad = int.Parse(Console.ReadLine());

                if (iEdad >= 18)
                {
                    Console.WriteLine("Mayor de edad");
                }
                else
                {
                    Console.WriteLine("Menor de Edad");
                }
                iCont++;
            }
        }

    }
}
