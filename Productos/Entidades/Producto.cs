using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        // Propiedades Autoimplementadas para representar la tabla Producto
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PVP { get; set; }
        public int Cantidad { get; set; }

        public string Rubro { get; set; }
        public string Marca { get; set; }
        public string UnidadMedida { get; set; }


    }
}
