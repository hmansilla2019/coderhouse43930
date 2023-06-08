using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace ListasMatrices
{
    public class Producto
    {
        // SELECT [Id],[Descripciones],[Costo],[PrecioVenta],[Stock],[IdUsuario] FROM [SistemaGestion].[dbo].[Producto]
        public long Id { get; set; }
        public string Descripciones { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public long IdUsuario { get; set; }

        public List<Producto> Productos { get; set; }

        public Producto()
        {
            Productos = new List<Producto>();
        }
      
        public List<Producto> ListarProductos()
        {

            string connectionString = @"Server=LAPTOP-D0DVPQB2\SQLHUGO;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto";
            var listaProductos = new List<Producto>();

            using (SqlConnection conect = new SqlConnection(connectionString))
            {
                conect.Open();
                using (SqlCommand comando = new SqlCommand(query, conect))
                {
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            var producto = new Producto();
                            producto.Id = dr.GetInt64("Id");
                            producto.Descripciones = dr.GetString("Descripciones");
                            producto.Costo =dr.GetDecimal("Costo");
                            producto.PrecioVenta = dr.GetDecimal("PrecioVenta");
                            producto.Stock = dr.GetInt32("Stock");
                            producto.IdUsuario =dr.GetInt64("IdUsuario");
                            listaProductos.Add(producto);
                        }

                    }

                }
            }
            return listaProductos;
        }

        public Producto GetProducto(int id)
        {

            string connectionString = @"Server=LAPTOP-D0DVPQB2\SQLHUGO;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto WHERE Id=@pId";
            var producto = new Producto();

            using (SqlConnection conect = new SqlConnection(connectionString))
            {
                conect.Open();
                using (SqlCommand comando = new SqlCommand(query, conect))
                {

                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = "@pId";
                    parametro.DbType = DbType.Int32;
                    parametro.Value = Id;
                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                      
                            producto.Id = dr.GetInt64("Id");
                            producto.Descripciones = dr.GetString("Descripciones");
                            producto.Costo = dr.GetDecimal("Costo");
                            producto.PrecioVenta = dr.GetDecimal("PrecioVenta");
                            producto.Stock = dr.GetInt32("Stock");
                            producto.IdUsuario = dr.GetInt64("IdUsuario");
                          
                        }
                    }

                }
            }
            return producto;
        }

    }
}
