using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RelacionesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new FacturaA();
            factura.NroFactura = 1;
            factura.Fecha = DateTime.Now;
            factura.Cliente = "Hugo";
            

            FacturaA facturaA = new FacturaA();
            facturaA.NroFactura = 2;
            facturaA.Fecha = DateTime.Now;
            facturaA.Cliente = "Lucia";
            facturaA.ivaDiscriminado = 21.0f;

            FacturaC facturaC = new FacturaC();
            facturaC.NroFactura = 2;
            facturaC.Fecha = DateTime.Now;
            facturaC.Cliente = "Lucia";

            FuncionesGenerales.MostrarMensaje("Ingrese su nombre: ");
            FuncionesGenerales.MostrarMensaje("Bienvenido: " + FuncionesGenerales.IngresarValor());

            Console.ReadKey();

        }
    }
}
