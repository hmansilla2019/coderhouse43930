
using ListasMatrices;
namespace Productos
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            dgArticulos.AutoGenerateColumns = true;
            dgArticulos.DataSource = producto.ListarProductos();

            producto = producto.GetProducto(1);
        }
    }
}