using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionesObjetos
{
    public abstract class Impuestos
    {
        public abstract void CobrarImpuesto();

        public virtual void DescontarImpuestos()
        {
            Console.WriteLine("Aplica descuento de impuesto");
        }

    }
}
