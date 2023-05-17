using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasMatrices
{
    internal class FacturaCabecera
    {
        public int NumeroFactura { get; set; }

        // Tarea crear una clase Cliente con Nombre, Apellido, CUIT, TELEFONO y CODIGO de CLIENTE
        public string NombreCliente { get; set; }

        public List<FacturaDetalle> Detalles { get;set; }

        public FacturaCabecera()
        {
            Detalles = new List<FacturaDetalle>();
        }


    }
}
