using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasMatrices
{
    internal class Producto
    {
        public string Descripcion { get; set; }
        public int Precio { get; set; }

        public List<Producto> Productos { get; set; }

        public Producto()
        {
            Productos = new List<Producto>();
        }
        public Producto(string descripcion, int precio)
        {
            Productos = new List<Producto>();
            Descripcion = descripcion;
            Precio = precio;
        }   

        public void InsertarEnLista(Producto[] productos)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                Productos.Add(new Producto(productos[i].Descripcion, productos[i].Precio));
            }

        }

    }
}
