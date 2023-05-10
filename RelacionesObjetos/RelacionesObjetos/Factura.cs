using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionesObjetos
{
    public class Factura:Impuestos,IArgentina,IChile
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
    
        public virtual void AltaFactura(int nroFactura, DateTime fecha, string Cliente)
        {
            this.NroFactura = nroFactura;
            this.Fecha = fecha;
            this.Cliente = Cliente;

        }

        public override void CobrarImpuesto()
        {
            Console.WriteLine("Por supuesto....");
        }

        public virtual void IndicarArancel()
        {
            Console.WriteLine("50%");
        }

        public virtual void IndicarPagaGanacias()
        {
            Console.WriteLine("70%");
        }
    }
}
