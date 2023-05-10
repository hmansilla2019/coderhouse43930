using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class MetodosObligatorios
    {
        public abstract void Verificar();

        public virtual void Pintar()
        {
            Console.WriteLine("Rojo");
        }

        public void CambiarEquipo()
        {
            Console.WriteLine("Se cambio el Equipo");
        }
    }
}
