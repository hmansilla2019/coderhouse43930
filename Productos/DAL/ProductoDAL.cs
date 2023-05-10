using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoDAL
    {

        public List<Producto> GetProductos(string connectionString)
        {
            List<Producto> ProductosList = new List<Producto>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select p.IdProducto, p.Descripcion, p.PVP,";
            selectSQL += " p.IdMarca, p.Marca,p.Rubro,";
            selectSQL += " p.UnidadMedida,p.Cantidad";
            selectSQL += " from Producto p";
             con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Producto Producto = new Producto();
                    Producto.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    Producto.Descripcion = Convert.ToString(dr["Descripcion"]);
                    Producto.PVP = Convert.ToDecimal(dr["PVP"]);
                    Producto.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    Producto.Rubro = Convert.ToString(dr["Rubro"]);
                    Producto.UnidadMedida = Convert.ToString(dr["UnidadMedida"]);
                    Producto.Marca = Convert.ToString(dr["Marca"]);
                    ProductosList.Add(Producto);
                }
            }
            con.Close();
            return ProductosList;
        }

        public void CrearProducto(string connectionString, Producto Producto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CrearProducto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Producto.Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@Rubro", Producto.Rubro));
                    cmd.Parameters.Add(new SqlParameter("@Marca", Producto.Marca));
                    cmd.Parameters.Add(new SqlParameter("@UnidadMedida", Producto.UnidadMedida));
                    cmd.Parameters.Add(new SqlParameter("@PVP", Producto.PVP));
                    cmd.Parameters.Add(new SqlParameter("@Cantidad", Producto.Cantidad));
                    con.Open();
                    cmd.ExecuteNonQuery(); // se usa para ABM no consultas
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Producto GetProductoData(string connectionString, int ProductoId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Select p.IdProducto, p.Descripcion, p.PVP,";
            selectSQL += " p.IdMarca, p.Marca,p.Rubro,";
            selectSQL += " p.UnidadMedida,p.Cantidad";
            selectSQL += " from Producto p";
            selectSQL += " where IdProducto = " + ProductoId;
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            Producto Producto = new Producto();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Producto.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    Producto.Descripcion = Convert.ToString(dr["Descripcion"]);
                    Producto.PVP = Convert.ToDecimal(dr["PVP"]);
                    Producto.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    Producto.Rubro = Convert.ToString(dr["Rubro"]);
                    Producto.UnidadMedida = Convert.ToString(dr["UnidadMedida"]);
                    Producto.Marca = Convert.ToString(dr["Marca"]);
                  
                }
            }
            con.Close();
            return Producto;
        }


        public void EditarProducto(string connectionString, Producto Producto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateProducto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IdProducto", Producto.IdProducto));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Producto.Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@Rubro", Producto.Rubro));
                    cmd.Parameters.Add(new SqlParameter("@Marca", Producto.Marca));
                    cmd.Parameters.Add(new SqlParameter("@UnidadMedida", Producto.UnidadMedida));
                    cmd.Parameters.Add(new SqlParameter("@PVP", Producto.PVP));
                    cmd.Parameters.Add(new SqlParameter("@Cantidad", Producto.Cantidad));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProducto(string connectionString, int ProductoId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteProducto", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IdProducto", ProductoId));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




    }
}
