using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasMatrices
{

  
    internal class FacturaDetalle
    {
        public FacturaDetalle()
        {
            producto = new Producto();
        }
        public int item { get; set; }
        public int cantidad { get; set; }
        public Producto producto { get; set; }

    
    }
}
