using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionesObjetos
{
    public class FacturaC:Factura
    {
        public string Observaciones { get; set; }
        public override void AltaFactura(int nroFactura, DateTime fecha, string Cliente)
        {
            base.AltaFactura(nroFactura, fecha, Cliente);   
            this.Observaciones = "FacturaB ";
        }

        public override void CobrarImpuesto()
        {
            Console.WriteLine("Por supuesto 80%");
        }
    }
}
