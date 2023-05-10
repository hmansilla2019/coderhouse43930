using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionesObjetos
{
    public class FacturaA : Factura
    {
        public float ivaDiscriminado { get; set; }


        public void AltaFactura(int nroFactura, DateTime fecha, string Cliente,float ivaDiscriminado)
        {
            AltaFactura(nroFactura, fecha, Cliente);
            this.ivaDiscriminado = ivaDiscriminado;
        }

        public override void CobrarImpuesto()
        {
            Console.WriteLine("Por supuesto, un 50%");
        }

        public override void DescontarImpuestos()
        {
            Console.WriteLine("Aplica descuento de impuesto 5%");
        }

        public override void IndicarArancel()
        {
            Console.WriteLine("150%");
        }
    }
}
